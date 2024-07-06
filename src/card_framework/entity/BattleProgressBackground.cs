using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleProgressBackground : ComponentContainer
    {
        public BattleProgressBackground () {
            SetName("battle_progress_background");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleProgressBackgroundModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new BattleProgress());
            this.AddComponent(new BattleProgressIcon());
        }
    }
}