using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperRarityRedIcon : ComponentContainer
    {
        public CardUpperRarityRedIcon () {
            this.SetName("card_upper_rarity_red_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperRarityRedIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}