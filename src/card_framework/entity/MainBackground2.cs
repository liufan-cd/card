using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBackground2 : ComponentContainer
    {
        public MainBackground2 () {
            this.SetName("main_background2");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBackground2Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}