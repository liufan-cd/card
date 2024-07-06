using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MapCloseButton : ComponentContainer
    {
        public MapCloseButton () {
            this.SetName("map_close_button");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MapCloseButtonModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}