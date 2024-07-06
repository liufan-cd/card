using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleProgressIcon : ComponentContainer
    {
        public BattleProgressIcon () {
            SetName("battle_progress_icon");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleProgressIconModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}