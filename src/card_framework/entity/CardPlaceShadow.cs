using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardPlaceShadow : ComponentContainer
    {
        public CardPlaceShadow () {
            SetName("card_place_shadow");
            Dictionary<string, string> config = GetConfig();
            Model = new CardPlaceShadowModel(config);
            View = Model.GenerateView();
            EventHandle = new CardPlaceShadowEventHandle(this);
        }
    
        public CardPlaceShadow (int id) : this() {
            this.id = id;
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}