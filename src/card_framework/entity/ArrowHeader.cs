using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class ArrowHeader : ComponentContainer
    {
        public ArrowHeader () {
            this.SetName("arrow_header");
            Dictionary<string, string> config = GetConfig();
            this.Model = new ArrowHeaderModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}