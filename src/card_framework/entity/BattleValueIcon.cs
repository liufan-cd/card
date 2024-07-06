using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleValueIcon : ComponentContainer
    {
        public BattleValueIcon () {
            SetName("battle_value_icon");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleValueIconModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}