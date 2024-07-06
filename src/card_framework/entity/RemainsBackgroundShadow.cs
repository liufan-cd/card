using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class RemainsBackgroundShadow : ComponentContainer
    {
        public RemainsBackgroundShadow () {
            this.SetName("remains_background_shadow");
            Dictionary<string, string> config = GetConfig();
            this.Model = new RemainsBackgroundShadowModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new RemainsBackgroundShadowEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new RemainsBackground());
        }
    }
}