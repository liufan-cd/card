using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleButtonBackground : ComponentContainer
    {
        public BattleButtonBackground () {
            this.SetName("battle_button_background");
            Dictionary<string, string> config = GetConfig();
            this.Model = new BattleButtonBackgroundModel(config);
            this.View = Model.GenerateView();
            // this.EventHandle = new BattleButtonBackgroundEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new BattlePauseButton());
            this.AddComponent(new FastForwardButton15());
            this.AddComponent(new FastForwardButton20());
            this.AddComponent(new BattleDayText());
        }
    }
}