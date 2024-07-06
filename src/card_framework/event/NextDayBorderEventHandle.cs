using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class NextDayBorderEventHandle : DefaultEventHandle
    {
        public NextDayBorderEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}