using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class SettingIcon : ComponentContainer
    {
        public SettingIcon () {
            this.SetName("setting_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new SettingIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}