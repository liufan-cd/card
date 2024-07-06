using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class RemainsBackgroundShadowEventHandle : FocusOnEventHandle
    {
        public RemainsBackgroundShadowEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}