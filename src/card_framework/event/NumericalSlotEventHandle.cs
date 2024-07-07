using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class NumericalSlotEventHandle : DefaultEventHandle
    {
        public NumericalSlotEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}