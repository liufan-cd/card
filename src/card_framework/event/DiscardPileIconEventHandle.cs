using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class DiscardPileIconEventHandle : DefaultEventHandle
    {
        public DiscardPileIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}