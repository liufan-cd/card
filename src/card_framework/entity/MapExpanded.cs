using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MapExpanded : ComponentContainer
    {
        public MapExpanded () {
            this.SetName("map_expanded");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MapExpandedModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}