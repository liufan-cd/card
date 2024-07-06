using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class HandText : ComponentContainer
    {
        public HandText () {
            this.SetName("hand_text");
            Dictionary<string, string> config = GetConfig();
            this.Model = new HandTextModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}