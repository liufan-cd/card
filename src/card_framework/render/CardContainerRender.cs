using System;
using src.card_framework.abs;
using src.card_framework.util;
using src.card_framework.view;
using UnityEngine;

namespace src.card_framework.render
{
    public class CardContainerRender : DefaultRender
    {
        public override void DoRender(AbsView view)
        {
            CardContainerView cardContainerView = (CardContainerView)view;
            float deltaTime = Time.deltaTime;

            if (view.AbsPosition != Transform.position)
            {
                Vector3 targetPosition = view.AbsPosition - cardContainerView.GetOffset();
                Vector3 originPosition = Transform.position;
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
                Transform.position = originPosition + direct * (speed * deltaTime);
                
                // 旋转
                Vector3 eulerAngles = Transform.eulerAngles;

                float clamp;
                
                // 考虑鼠标点击位置，计算偏移方向
                if (cardContainerView.GetOffset().y < 0)
                {
                    clamp = Mathf.Min(cardContainerView.GetOffset().y, -1.8f);
                }
                else
                {
                    clamp = Mathf.Max(cardContainerView.GetOffset().y, 1.8f);
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

                Transform.eulerAngles = new Vector3(eulerAngles.x, eulerAngles.y, clamp);
            }
            else
            {
                Transform.position = view.AbsPosition;
                Transform.eulerAngles = view.AbsEulerAngles;
            }
            
            Transform.localScale = view.AbsScale;
            Renderer.sortingOrder = view.AbsLayer;
            GameObject.SetActive(view.IsActive);
        }
    }
}