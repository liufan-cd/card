using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MapCloseText : ComponentContainer
    {
        public MapCloseText () {
            this.SetName("map_close_text");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MapCloseTextModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}