using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardBelowPictureFrameEventHandle : DefaultEventHandle
    {
        public CardBelowPictureFrameEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}