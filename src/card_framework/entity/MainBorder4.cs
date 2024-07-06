using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBorder4 : ComponentContainer
    {
        public MainBorder4 () {
            this.SetName("main_border4");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBorder4Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}