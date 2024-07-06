using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MapBundling : ComponentContainer
    {
        public MapBundling () {
            this.SetName("map_bundling");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MapBundlingModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}