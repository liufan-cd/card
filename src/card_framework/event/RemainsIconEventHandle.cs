using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class RemainsIconEventHandle : DefaultEventHandle
    {
        public RemainsIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}