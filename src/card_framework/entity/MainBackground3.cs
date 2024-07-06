using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBackground3 : ComponentContainer
    {
        public MainBackground3 () {
            this.SetName("main_background3");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBackground3Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}