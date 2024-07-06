using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleDecreasedValue : ComponentContainer
    {
        public BattleDecreasedValue () {
            SetName("battle_decreased_value");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleDecreasedValueModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}