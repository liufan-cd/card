using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class FastForwardButton20EventHandle : FocusOnEventHandle
    {
        public FastForwardButton20EventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}