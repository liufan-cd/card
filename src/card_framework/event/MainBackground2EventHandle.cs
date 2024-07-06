using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MainBackground2EventHandle : DefaultEventHandle
    {
        public MainBackground2EventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}