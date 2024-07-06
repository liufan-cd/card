using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class RemainsBackground : ComponentContainer
    {
        public RemainsBackground () {
            this.SetName("remains_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new RemainsBackgroundModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new RemainsIcon());
        }
    }
}