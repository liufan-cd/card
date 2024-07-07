using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperBackgroundEventHandle : DefaultEventHandle
    {
        public CardUpperBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}