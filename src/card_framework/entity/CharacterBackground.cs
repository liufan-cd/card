using src.card_framework.abs;

namespace src.card_framework.entity
{
    public class CharacterBackground : ComponentContainer
    {
        public CharacterBackground()
        {
            this.SetName("character_background");
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}