using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class FastForwardButton20 : ComponentContainer
    {
        public FastForwardButton20 () {
            this.SetName("fast_forward_button_20");
            Dictionary<string, string> config = GetConfig();
            this.Model = new FastForwardButton20Model(config);
            this.View = Model.GenerateView();
            this.EventHandle = new FastForwardButton20EventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}