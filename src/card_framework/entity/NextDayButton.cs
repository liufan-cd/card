using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class NextDayButton : ComponentContainer
    {
        public NextDayButton () {
            this.SetName("next_day_button");
            Dictionary<string, string> config = GetConfig();
            this.Model = new NextDayButtonModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new NextDayButtonEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new NextDayBorder());
            this.AddComponent(new NextDayText());
        }
    }
}