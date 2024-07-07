using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class ArrowHeaderEventHandle : DefaultEventHandle
    {
        public ArrowHeaderEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}