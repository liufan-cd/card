using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class NextDayText : ComponentContainer
    {
        public NextDayText () {
            this.SetName("next_day_text");
            Dictionary<string, string> config = GetConfig();
            this.Model = new NextDayTextModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}