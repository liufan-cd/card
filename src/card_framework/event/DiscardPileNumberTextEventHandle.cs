using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class DiscardPileNumberTextEventHandle : DefaultEventHandle
    {
        public DiscardPileNumberTextEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}