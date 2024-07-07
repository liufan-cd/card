using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowBuildingCardEventHandle : DefaultEventHandle
    {
        public CardBelowBuildingCardEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}