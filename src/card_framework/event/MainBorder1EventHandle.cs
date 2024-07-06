using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MainBorder1EventHandle : DefaultEventHandle
    {
        public MainBorder1EventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}