using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowFace : ComponentContainer
    {
        public CardBelowFace () {
            this.SetName("card_below_face");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowFaceModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}