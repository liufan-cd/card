using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleValueBackground : ComponentContainer
    {
        public BattleValueBackground () {
            SetName("battle_value_background");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleValueBackgroundModel(config);
            View = Model.GenerateView();
            EventHandle = new BattleValueBackgroundEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new BattleValueIcon());
            this.AddComponent(new BattleValue());
        }
    }
}