using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class NextDayButtonEventHandle : FocusOnEventHandle
    {
        public NextDayButtonEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}