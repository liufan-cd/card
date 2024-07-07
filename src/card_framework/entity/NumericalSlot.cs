using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class NumericalSlot : ComponentContainer
    {
        public NumericalSlot () {
            this.SetName("Numerical_slot");
            Dictionary<string, string> config = GetConfig();
            this.Model = new NumericalSlotModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}