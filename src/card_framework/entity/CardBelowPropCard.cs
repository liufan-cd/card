using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowPropCard : ComponentContainer
    {
        public CardBelowPropCard () {
            this.SetName("card_below_prop_card");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowPropCardModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}