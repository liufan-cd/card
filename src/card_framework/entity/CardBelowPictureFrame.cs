using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowPictureFrame : ComponentContainer
    {
        public CardBelowPictureFrame () {
            this.SetName("card_below_picture_frame");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowPictureFrameModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}