using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattlePauseButton : ComponentContainer
    {
        public BattlePauseButton () {
            SetName("battle_pause_button");
            Dictionary<string, string> config = GetConfig();
            Model = new BattlePauseButtonModel(config);
            View = Model.GenerateView();
            EventHandle = new BattlePauseButtonEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}