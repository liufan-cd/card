using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowNumericalSlotEventHandle : DefaultEventHandle
    {
        public CardBelowNumericalSlotEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}