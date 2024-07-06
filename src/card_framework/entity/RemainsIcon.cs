using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class RemainsIcon : ComponentContainer
    {
        public RemainsIcon () {
            this.SetName("remains_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new RemainsIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}