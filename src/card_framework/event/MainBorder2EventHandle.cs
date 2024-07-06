using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MainBorder2EventHandle : DefaultEventHandle
    {
        public MainBorder2EventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}