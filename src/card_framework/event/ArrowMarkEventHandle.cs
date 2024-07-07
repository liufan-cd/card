using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class ArrowMarkEventHandle : DefaultEventHandle
    {
        public ArrowMarkEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}