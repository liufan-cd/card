using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowRedCard : ComponentContainer
    {
        public CardBelowRedCard () {
            this.SetName("card_below_red_card");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowRedCardModel(config);
            this.View = Model.GenerateView();
            View.GameObjectLayer = 7;
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}