using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class FastForwardButton15 : ComponentContainer
    {
        public FastForwardButton15 () {
            this.SetName("fast_forward_button_15");
            Dictionary<string, string> config = GetConfig();
            this.Model = new FastForwardButton15Model(config);
            this.View = Model.GenerateView();
            this.EventHandle = new FastForwardButton15EventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}