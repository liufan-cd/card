using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BuildingPlace : ComponentContainer, LocalSingleton<BuildingPlace>
    {
        public static BuildingPlace singleton;
    
        public BuildingPlace () {
            SetName("building_place");
            Dictionary<string, string> config = GetConfig();
            Model = new BuildingPlaceModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }

        public BuildingPlace GetSingleton()
        {
            if (singleton == null)
            {
                singleton = new BuildingPlace();
            }

            return singleton;
        }
    }
}