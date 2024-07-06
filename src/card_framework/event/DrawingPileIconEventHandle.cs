using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class DrawingPileIconEventHandle : DefaultEventHandle
    {
        public DrawingPileIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}