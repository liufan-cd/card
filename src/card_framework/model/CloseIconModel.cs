using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.view;

namespace src.card_framework.model
{
    public class CloseIconModel : DefaultModel
    {
        public CloseIconModel(Dictionary<string, string> config) : base(config)
        {
        
        }

        public override AbsView CreateViewOrigin()
        {
            return new CloseIconView();
        }

        public override AbsView GenerateView()
        {
            AbsView view = base.GenerateView();
            return view;
        }     
    }
}