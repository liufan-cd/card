using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperRarityRedIconEventHandle : DefaultEventHandle
    {
        public CardUpperRarityRedIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}