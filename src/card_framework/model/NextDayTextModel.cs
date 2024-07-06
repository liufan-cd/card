using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.view;

namespace src.card_framework.model
{
    public class NextDayTextModel : DefaultModel
    {
        public NextDayTextModel(Dictionary<string, string> config) : base(config)
        {
        
        }

        public override AbsView CreateViewOrigin()
        {
            return new NextDayTextView();
        }

        public override AbsView GenerateView()
        {
            AbsView view = base.GenerateView();
            return view;
        }     
    }
}