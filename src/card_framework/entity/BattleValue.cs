using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleValue : ComponentContainer
    {
        public BattleValue () {
            SetName("battle_value");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleValueModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}