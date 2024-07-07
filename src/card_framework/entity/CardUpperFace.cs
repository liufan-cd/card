using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperFace : ComponentContainer
    {
        public CardUpperFace () {
            this.SetName("card_upper_face");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperFaceModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}