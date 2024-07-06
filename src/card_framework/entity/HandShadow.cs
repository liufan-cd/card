using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class HandShadow : ComponentContainer
    {
        public HandShadow () {
            this.SetName("hand_shadow");
            Dictionary<string, string> config = GetConfig();
            this.Model = new HandShadowModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}