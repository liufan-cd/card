using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardTextBcakground : ComponentContainer
    {
        public CardTextBcakground () {
            this.SetName("card_text_bcakground");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardTextBcakgroundModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}