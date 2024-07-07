using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BuildingPlaceBase : ComponentContainer
    {
        public BuildingPlaceBase () {
            this.SetName("building_place_base");
            Dictionary<string, string> config = GetConfig();
            this.Model = new BuildingPlaceBaseModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}