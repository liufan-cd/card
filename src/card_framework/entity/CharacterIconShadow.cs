using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.@event;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class CharacterIconShadow : ComponentContainer
    {
        public CharacterIconShadow () {
            this.SetName("character_icon_shadow");
            Dictionary<string, string> config = GetConfig();
            this.Model = new CharacterIconShadowModel(config);
            this.View = Model.GenerateView();
            this.EventHandle = new CharacterIconShadowEventHandle(this);
        }

        public override void BeforeChildrenStart()
        {
            this.AddComponent(new CharacterIcon());
        }
    }
}