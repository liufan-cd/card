using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleProgress : ComponentContainer
    {
        public BattleProgress () {
            SetName("battle_progress");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleProgressModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}