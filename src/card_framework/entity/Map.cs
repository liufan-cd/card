using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class Map : ComponentContainer
    {
        public Map () {
            this.SetName("map");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MapModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}