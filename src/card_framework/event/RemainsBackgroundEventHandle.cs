using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class RemainsBackgroundEventHandle : DefaultEventHandle
    {
        public RemainsBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}