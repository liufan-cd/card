using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardEventHandle : DefaultEventHandle
    {
        public CardEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}