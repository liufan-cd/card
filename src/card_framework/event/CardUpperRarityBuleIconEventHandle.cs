using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperRarityBuleIconEventHandle : DefaultEventHandle
    {
        public CardUpperRarityBuleIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}