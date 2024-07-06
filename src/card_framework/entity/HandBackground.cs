using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;
using UnityEngine;

namespace src.card_framework.entity
{
    public class HandBackground : ComponentContainer
    {
        public HandBackground () {
            this.SetName("hand_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new HandBackgroundModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            for (int i = 0; i < 5; i++)
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
        
            while ((child = child.NextComponent) != Root)
            {
                offset += width;

                if (!child.GetEventHandle().IsOnDrag())
                {
                    child.SetLocalPosition(new Vector3(offset, 0, 0));
                    child.SetLocalEulerAngles(new Vector3(0, 0, 0));
                }
            }
        }
    }
}