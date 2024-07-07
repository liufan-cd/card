using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperBackground : ComponentContainer
    {
        public CardUpperBackground () {
            this.SetName("card_upper_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperBackgroundModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}