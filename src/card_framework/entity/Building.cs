using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;
using UnityEngine;

namespace src.card_framework.entity
{
    public class Building : ComponentContainer
    {
        public Building () {
            SetName("building");
            Dictionary<string, string> config = GetConfig();
            Model = new BuildingModel(config);
            View = Model.GenerateView();
        }

        public Building(int id, Vector3 position, ComponentContainer parent) : this()
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