using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowWasteCardEventHandle : DefaultEventHandle
    {
        public CardBelowWasteCardEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}