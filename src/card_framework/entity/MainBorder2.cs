using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBorder2 : ComponentContainer
    {
        public MainBorder2 () {
            this.SetName("main_border2");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBorder2Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}