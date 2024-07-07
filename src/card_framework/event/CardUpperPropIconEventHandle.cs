using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperPropIconEventHandle : DefaultEventHandle
    {
        public CardUpperPropIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}