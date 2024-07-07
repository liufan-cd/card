using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperWasteIcon : ComponentContainer
    {
        public CardUpperWasteIcon () {
            this.SetName("card_upper_waste_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperWasteIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}