using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class DiscardPileIcon : ComponentContainer
    {
        public DiscardPileIcon () {
            this.SetName("discard_pile_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new DiscardPileIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}