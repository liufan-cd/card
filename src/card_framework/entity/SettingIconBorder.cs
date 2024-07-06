using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class SettingIconBorder : ComponentContainer
    {
        public SettingIconBorder () {
            this.SetName("setting_icon_border");
            Dictionary<string, string> config = GetConfig();
            this.Model = new SettingIconBorderModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new SettingIconBorderEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new SettingIcon());
        }
    }
}