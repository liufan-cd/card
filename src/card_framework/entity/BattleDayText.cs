using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class BattleDayText : ComponentContainer
    {
        public BattleDayText () {
            SetName("battle_day_text");
            Dictionary<string, string> config = GetConfig();
            Model = new BattleDayTextModel(config);
            View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}