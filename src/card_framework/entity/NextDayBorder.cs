using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class NextDayBorder : ComponentContainer
    {
        public NextDayBorder () {
            this.SetName("next_day_border");
            Dictionary<string, string> config = GetConfig();
            this.Model = new NextDayBorderModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}