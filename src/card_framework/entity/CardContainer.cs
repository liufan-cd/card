using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;
using src.card_framework.render;
using src.card_framework.view;
using UnityEngine;

namespace src.card_framework.entity
{
    public class CardContainer : ComponentContainer
    {
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
        
        }
        
        public Vector3 GetOffset()
        {
            return ((CardContainerView)View).GetOffset();
        }

        public void SetOffset(Vector3 offset)
        {
            ((CardContainerView)View).SetOffset(offset);
        }
    }
}