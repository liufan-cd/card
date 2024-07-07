using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowMinionIconEventHandle : DefaultEventHandle
    {
        public CardBelowMinionIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}