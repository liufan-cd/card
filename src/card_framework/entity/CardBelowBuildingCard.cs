using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowBuildingCard : ComponentContainer
    {
        public CardBelowBuildingCard () {
            this.SetName("card_below_building_Card");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowBuildingCardModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}