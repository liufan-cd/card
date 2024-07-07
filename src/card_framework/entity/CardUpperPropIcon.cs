using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperPropIcon : ComponentContainer
    {
        public CardUpperPropIcon () {
            this.SetName("card_upper_prop_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperPropIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}