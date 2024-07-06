using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleValueBackgroundEventHandle : FocusOnEventHandle
    {
        public BattleValueBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}