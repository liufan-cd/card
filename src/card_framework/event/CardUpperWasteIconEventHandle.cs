using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperWasteIconEventHandle : DefaultEventHandle
    {
        public CardUpperWasteIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}