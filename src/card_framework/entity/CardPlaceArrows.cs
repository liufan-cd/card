using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;
using UnityEngine;

namespace src.card_framework.entity
{
    public class CardPlaceArrows : ComponentContainer, LocalSingleton<CardPlaceArrows>
    {
        public static CardPlaceArrows singleton;
    
        public CardPlaceArrows () {
            SetName("card_place_arrows");
            Dictionary<string, string> config = GetConfig();
            Model = new CardPlaceArrowsModel(config);
            View = Model.GenerateView();
        }
    
        public CardPlaceArrows GetSingleton()
        {
            if (singleton == null)
            {
                singleton = new CardPlaceArrows();
            }

            return singleton;
        }

        public override void BeforeChildrenStart()
        {
        
        }

        public void SetSize(Vector2 size)
        {
            this.View.SizeX = size.x;
            this.View.SizeY = size.y;
            this.Render.CalculateScale(View);
        }
    }
}