using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBorder3 : ComponentContainer
    {
        public MainBorder3 () {
            this.SetName("main_border3");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBorder3Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}