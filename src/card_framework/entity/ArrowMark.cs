using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class ArrowMark : ComponentContainer
    {
        public ArrowMark () {
            this.SetName("arrow_mark");
            Dictionary<string, string> config = GetConfig();
            this.Model = new ArrowMarkModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}