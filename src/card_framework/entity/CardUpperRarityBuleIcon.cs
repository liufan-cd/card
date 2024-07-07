using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperRarityBuleIcon : ComponentContainer
    {
        public CardUpperRarityBuleIcon () {
            this.SetName("card_upper_rarity_bule_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperRarityBuleIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}