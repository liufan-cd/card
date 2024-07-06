using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class DrawingPileBackgroundEventHandle : FocusOnEventHandle
    {
        public DrawingPileBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}