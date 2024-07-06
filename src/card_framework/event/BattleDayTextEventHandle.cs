using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleDayTextEventHandle : DefaultEventHandle
    {
        public BattleDayTextEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}