using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperRarityPurpleIcon : ComponentContainer
    {
        public CardUpperRarityPurpleIcon () {
            this.SetName("card_upper_rarity_purple_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperRarityPurpleIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}