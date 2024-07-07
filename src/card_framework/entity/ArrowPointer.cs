using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class ArrowPointer : ComponentContainer
    {
        public ArrowPointer () {
            this.SetName("arrow_pointer");
            Dictionary<string, string> config = GetConfig();
            this.Model = new ArrowPointerModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}