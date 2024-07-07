using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BuildingPlaceFace : ComponentContainer
    {
        public BuildingPlaceFace () {
            this.SetName("building_place_face");
            Dictionary<string, string> config = GetConfig();
            this.Model = new BuildingPlaceFaceModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}