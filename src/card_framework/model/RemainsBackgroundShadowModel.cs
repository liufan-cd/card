using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.view;

namespace src.card_framework.model
{
    public class RemainsBackgroundShadowModel : DefaultModel
    {
        public RemainsBackgroundShadowModel(Dictionary<string, string> config) : base(config)
        {
        
        }

        public override AbsView CreateViewOrigin()
        {
            return new RemainsBackgroundShadowView();
        }

        public override AbsView GenerateView()
        {
            AbsView view = base.GenerateView();
            view.GameObjectLayer = 7;
            return view;
        }     
    }
}