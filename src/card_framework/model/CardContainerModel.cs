using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.view;
using UnityEngine;

namespace src.card_framework.model
{
    public class CardContainerModel : DefaultModel
    {
        public CardContainerModel(Dictionary<string, string> config)
        {
            Path = config["path"];
            LocalScale = new Vector3(1, 1, 1);
        }

        public override AbsView CreateViewOrigin()
        {
            return new CardContainerView();
        }

        public override AbsView GenerateView()
        {
            AbsView view = base.GenerateView();
            view.GameObjectLayer = 7;
            return view;
        }     
    }
}