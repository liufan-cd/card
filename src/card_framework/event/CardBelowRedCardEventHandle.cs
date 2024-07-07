using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowRedCardEventHandle : DefaultEventHandle
    {
        public CardBelowRedCardEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}