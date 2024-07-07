using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class ArrowPointerEventHandle : DefaultEventHandle
    {
        public ArrowPointerEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}