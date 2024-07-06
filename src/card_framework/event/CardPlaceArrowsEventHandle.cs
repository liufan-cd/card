using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardPlaceArrowsEventHandle : DefaultEventHandle
    {
        public CardPlaceArrowsEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}