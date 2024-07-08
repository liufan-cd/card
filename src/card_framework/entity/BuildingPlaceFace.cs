using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;
using UnityEngine;

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
        
        public BuildingPlaceFace(int id, Vector3 position, ComponentContainer parent) : this()
        {
            this.id = id;
            this.View.AbsPosition = position;
            this.View.LocalPosition = position - parent.GetAbsPosition();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}