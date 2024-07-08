using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;
using UnityEngine;

namespace src.card_framework.entity
{
    public class HandBackground : ComponentContainer
    {
        private int tick = 0;
        int i;

        public HandBackground () {
            this.SetName("hand_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new HandBackgroundModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            for (i = 0; i < 8; i++)
            {
                AddComponent(new CardContainer(i));
            }
        }

        public override void BeforeChildrenUpdate()
        {
            BaseComponent child = Root;
            float width = Model.SizeX;
            float offset = -width / 2;
            width /= Children.Count + 1;
            BaseComponent dragChild = null;
            
            while ((child = child.NextComponent) != Root)
            {
                if (child.GetEventHandle().IsOnDrag())
                {
                    dragChild = child;
                    ChainNode(child.PreComponent, child.NextComponent);
                    break;
                }
            }

            BaseComponent pre = Root;
            child = Root;
            
            while ((child = child.NextComponent) != Root)
            {
                offset += width;

                if (dragChild == null || dragChild.GetAbsPosition().x > GetAbsPosition().x + offset)
                {
                    child.SetLocalPosition(new Vector3(offset, -(offset / 10) * (offset / 10), 0));
                    Vector3 eulerAngles = child.GetAbsEulerAngles();
                    child.SetAbsEulerAngles(new Vector3(eulerAngles.x, eulerAngles.y, offset * -2));
                }
                else
                {
                    ChainNode(pre, dragChild);
                    ChainNode(dragChild, child);
                    pre = dragChild;
                    child = dragChild;
                    dragChild = null;
                    continue;
                }
                
                pre = child;
            }

            if (dragChild != null)
            {
                ChainNode(Root.PreComponent, dragChild);
                ChainNode(dragChild, Root);
            }
        }

        public override void FixUpdate()
        {
            tick++;

            if (tick == 10)
            {
                tick = 0;
                
                if (i < 15)
                {
                    CardContainer container = new CardContainer(i++);
                    AddComponent(container);
                    container.Start();
                    DoSortLayer();
                }
                else
                {
                    ResortLayer(Root.NextComponent);
                }
            }
        }
    }
}