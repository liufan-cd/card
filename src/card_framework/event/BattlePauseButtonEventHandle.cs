using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattlePauseButtonEventHandle : FocusOnEventHandle
    {
        public BattlePauseButtonEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}