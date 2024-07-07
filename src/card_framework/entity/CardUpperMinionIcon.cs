using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperMinionIcon : ComponentContainer
    {
        public CardUpperMinionIcon () {
            this.SetName("card_upper_minion_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperMinionIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}