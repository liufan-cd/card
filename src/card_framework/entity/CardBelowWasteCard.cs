using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowWasteCard : ComponentContainer
    {
        public CardBelowWasteCard () {
            this.SetName("card_below_waste_card");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowWasteCardModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}