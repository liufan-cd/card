using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MapShadow : ComponentContainer
    {
        public MapShadow () {
            this.SetName("map_shadow");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MapShadowModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new MapShadowEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new Map());
            this.AddComponent(new MapBundling());
        }
    }
}