using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBorder1 : ComponentContainer
    {
        public MainBorder1 () {
            this.SetName("main_border1");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBorder1Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}