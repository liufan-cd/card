using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class DiscardPileBackground : ComponentContainer
    {
        public DiscardPileBackground () {
            this.SetName("discard_pile_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new DiscardPileBackgroundModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new DiscardPileBackgroundEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new DiscardPileIcon());
            this.AddComponent(new DiscardPileNumberText());
        }
    }
}