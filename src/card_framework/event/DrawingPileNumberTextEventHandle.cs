using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class DrawingPileNumberTextEventHandle : DefaultEventHandle
    {
        public DrawingPileNumberTextEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}