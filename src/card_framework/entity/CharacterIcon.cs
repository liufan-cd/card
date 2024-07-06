using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CharacterIcon : ComponentContainer
    {
        public CharacterIcon () {
            SetName("character_icon");
            Dictionary<string, string> config = GetConfig();
            Model = new CharacterIconModel(config);
            View = Model.GenerateView();
            // this.EventHandle = new CharacterIconEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}