using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CloseIconBorder : ComponentContainer
    {
        public CloseIconBorder () {
            this.SetName("close_icon_border");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CloseIconBorderModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new CloseIconBorderEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new CloseIcon());
        }
    }
}