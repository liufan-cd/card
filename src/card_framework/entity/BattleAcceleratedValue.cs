using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleAcceleratedValue : ComponentContainer
    {
        public BattleAcceleratedValue () {
            SetName("battle_accelerated_value");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleAcceleratedValueModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}