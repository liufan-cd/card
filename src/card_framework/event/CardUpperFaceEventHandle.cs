using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperFaceEventHandle : DefaultEventHandle
    {
        public CardUpperFaceEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}