using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MainBackground1EventHandle : DefaultEventHandle
    {
        public MainBackground1EventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}