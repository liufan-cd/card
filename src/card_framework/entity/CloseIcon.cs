using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CloseIcon : ComponentContainer
    {
        public CloseIcon () {
            this.SetName("close_icon");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CloseIconModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}