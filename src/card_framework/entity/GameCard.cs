using System;
using src.card_framework.abs;

namespace src.card_framework.entity
{
    public class GameCard : ComponentContainer {

        protected static readonly String BackGround = "card_background";

        public GameCard (int id) {
            SetName("card_background");
            this.id = id;
        }

        public override void BeforeChildrenStart()
        {
            AddComponent(new DefaultComponent("building_face"));
            AddComponent(new DefaultComponent("card_face"));
        }
    }
}