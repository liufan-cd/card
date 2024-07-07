using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CardBelowNumericalSlot : ComponentContainer
    {
        public CardBelowNumericalSlot () {
            this.SetName("card_below_numerical_slot");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CardBelowNumericalSlotModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}