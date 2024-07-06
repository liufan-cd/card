using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.view;

namespace src.card_framework.model
{
    public class MainBackground2Model : DefaultModel
    {
        public MainBackground2Model(Dictionary<string, string> config) : base(config)
        {
        
        }

        public override AbsView CreateViewOrigin()
        {
            return new MainBackground2View();
        }

        public override AbsView GenerateView()
        {
            AbsView view = base.GenerateView();
            return view;
        }     
    }
}