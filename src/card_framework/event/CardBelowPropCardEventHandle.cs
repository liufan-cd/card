using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowPropCardEventHandle : DefaultEventHandle
    {
        public CardBelowPropCardEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}