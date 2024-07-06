using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class DiscardPileBackgroundEventHandle : FocusOnEventHandle
    {
        public DiscardPileBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}