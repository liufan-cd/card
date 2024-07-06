using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class DrawingPileBackground : ComponentContainer
    {
        public DrawingPileBackground () {
            this.SetName("drawing_pile_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new DrawingPileBackgroundModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new DrawingPileBackgroundEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new DrawingPileIcon());
            this.AddComponent(new DrawingPileNumberText());
        }
    }
}