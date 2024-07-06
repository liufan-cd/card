using src.card_framework.entity;

namespace src.card_framework.@event
{
    public class CharacterIconShadowEventHandle : FocusOnEventHandle
    {
        public CharacterIconShadowEventHandle(CharacterIconShadow target) : base(target)
        {
            this.Target = target;
        }
    }
}