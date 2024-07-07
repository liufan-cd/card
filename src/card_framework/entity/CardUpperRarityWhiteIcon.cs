using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;
using UnityEngine;

namespace src.card_framework.entity
{
    public class CardUpperRarityWhiteIcon : ComponentContainer
    {
        public CardUpperRarityWhiteIcon () {
            this.SetName("card_upper_rarity_white_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperRarityWhiteIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}