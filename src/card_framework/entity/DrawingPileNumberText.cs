using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class DrawingPileNumberText : ComponentContainer
    {
        public DrawingPileNumberText () {
            this.SetName("drawing_pile_number_text");
            Dictionary<string, string> config = GetConfig();
            this.Model = new DrawingPileNumberTextModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}