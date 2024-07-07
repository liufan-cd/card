using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardUpperBuildIcon : ComponentContainer
    {
        public CardUpperBuildIcon () {
            this.SetName("card_upper_build_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardUpperBuildIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}