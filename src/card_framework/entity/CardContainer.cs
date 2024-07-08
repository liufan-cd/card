using System;
using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;
using src.card_framework.render;
using src.card_framework.util;
using src.card_framework.view;
using UnityEngine;

namespace src.card_framework.entity
{
    public class CardContainer : ComponentContainer
    {
        public Vector3 TransformPosition;
        public Vector3 TransformEulerAngles;
        
        public CardContainer () {
            SetName("card_container");
            Dictionary<string, string> config = GetConfig();
            Model = new CardContainerModel(config);
            View = Model.GenerateView();
            EventHandle = new CardContainerEventHandle(this);
            Render = new CardContainerRender();
        }

        public CardContainer(int id) : this()
        {
            this.id = id;
        }

        public override void BeforeChildrenStart()
        {
            AddComponent(new CardBelowRedCard());
            AddComponent(new CardUpperBackground());
            AddComponent(new CardUpperRarityWhiteIcon());
            AddComponent(new CardUpperFace());
            AddComponent(new CardUpperPropIcon());
            AddComponent(new NumericalSlot());
        }
        
        
        public override void AfterChildrenStart()
        {
            SetAbsScale(new Vector3(0.5f, 0.5f, 1));
            SetAbsPosition(Root.NextComponent.GetAbsPosition());
            
            foreach (BaseComponent child in Children.Values)
            {
                child.SetAbsScale(Vector3.Scale(GetAbsScale(), child.GetLocalScale()));
                child.SetLocalPosition(Vector3.Scale(child.GetAbsPosition() - GetAbsPosition(), child.GetAbsScale()));
            }
        }

        public override void BeforeChildrenUpdate()
        {
            CalculateAnimation();

            foreach (BaseComponent childrenValue in Children.Values)
            {
                Vector3 localPosition = childrenValue.GetLocalPosition();
                Vector3 eulerAngles = TransformEulerAngles;
                float distance = Vector3.Distance(Vector3.zero, localPosition);
                float angle = Vector3.Angle(Vector3.right, localPosition);
                float cos;

                if (localPosition.y >= 0)
                {
                    cos = Mathf.Cos((angle + eulerAngles.z) * Mathf.Deg2Rad);
                }
                else
                {
                    cos = Mathf.Cos((angle - eulerAngles.z) * Mathf.Deg2Rad);
                }

                float sin;
                if (localPosition.y >= 0)
                {
                    sin = Mathf.Sin((angle + eulerAngles.z) * Mathf.Deg2Rad);
                }
                else
                {
                    sin = - Mathf.Sin((angle - eulerAngles.z) * Mathf.Deg2Rad);
                }

                childrenValue.SetAbsPosition(new Vector3(TransformPosition.x + distance * cos,
                    TransformPosition.y + distance * sin, 0));
                childrenValue.SetAbsEulerAngles(eulerAngles);
            }
        }


        private void CalculateAnimation()
        {
            float deltaTime = Time.deltaTime;

            if (View.AbsPosition != TransformPosition)
            {
                Vector3 targetPosition = View.AbsPosition - GetOffset();
                Vector3 originPosition = TransformPosition;
                targetPosition.z = 0;
                originPosition.z = 0;
                // 距离
                float distance = Vector3.Distance(originPosition, targetPosition);
                // 计算偏移
                Vector3 arrow = targetPosition - originPosition;
                Vector3 direct = arrow.normalized;
                direct.z = 0;
                // 速度
                float speed = distance / deltaTime;
                speed = Math.Clamp(speed, 24f, 96f);
                // 速度拟合
                Vector3 curve = BezierUtil.BezierCurve(Vector3.zero, new Vector3(1f, 0.23f, 0), new Vector3(0.5f, 0.86f, 0),
                    new Vector3(1f, 1f, 0), Math.Min(1, distance / 8f));
                speed *= curve.y;
                TransformPosition = originPosition + direct * (speed * deltaTime);
                
                // 旋转
                Vector3 eulerAngles = TransformEulerAngles;

                float clamp;
                
                // 考虑鼠标点击位置，计算偏移方向
                if (GetOffset().y < 0)
                {
                    clamp = Mathf.Min(GetOffset().y, -1.8f);
                }
                else
                {
                    clamp = Mathf.Max(GetOffset().y, 1.8f);
                }

                // 考虑移动方向，计算偏移
                if (direct.x > 0)
                {
                    clamp = Mathf.Clamp(-30f * curve.y * clamp, -60f, 60f);
                }
                else
                {
                    clamp = Mathf.Clamp(30f * curve.y * clamp, -60f, 60f);
                }

                TransformEulerAngles = new Vector3(eulerAngles.x, eulerAngles.y, View.AbsEulerAngles.z + clamp);
            }
            else
            {
                TransformPosition = View.AbsPosition;
                TransformEulerAngles = View.AbsEulerAngles;
            }
        }

        public Vector3 GetOffset()
        {
            return ((CardContainerView) View).GetOffset();
        }

        public void SetOffset(Vector3 offset)
        {
            ((CardContainerView) View).SetOffset(offset);
        }
    }
}