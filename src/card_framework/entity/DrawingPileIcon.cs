using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class DrawingPileIcon : ComponentContainer
    {
        public DrawingPileIcon () {
            this.SetName("drawing_pile_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new DrawingPileIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}