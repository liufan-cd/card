using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowFaceEventHandle : DefaultEventHandle
    {
        public CardBelowFaceEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}