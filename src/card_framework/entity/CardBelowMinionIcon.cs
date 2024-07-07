using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowMinionIcon : ComponentContainer
    {
        public CardBelowMinionIcon () {
            this.SetName("card_below_minion_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowMinionIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}