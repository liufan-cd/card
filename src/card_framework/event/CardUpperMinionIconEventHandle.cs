using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperMinionIconEventHandle : DefaultEventHandle
    {
        public CardUpperMinionIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}