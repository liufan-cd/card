using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class NextDayTextEventHandle : DefaultEventHandle
    {
        public NextDayTextEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}