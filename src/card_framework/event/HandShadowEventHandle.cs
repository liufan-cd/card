using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class HandShadowEventHandle : DefaultEventHandle
    {
        public HandShadowEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}