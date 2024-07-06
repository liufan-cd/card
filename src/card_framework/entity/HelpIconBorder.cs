using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class HelpIconBorder : ComponentContainer
    {
        public HelpIconBorder () {
            this.SetName("help_icon_border");
            Dictionary<string, string> config = GetConfig();
            this.Model = new HelpIconBorderModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new HelpIconBorderEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new HelpIcon());
        }
    }
}