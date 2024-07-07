using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CardUpperBuildIconEventHandle : DefaultEventHandle
    {
        public CardUpperBuildIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}