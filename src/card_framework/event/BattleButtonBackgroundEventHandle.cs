using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleButtonBackgroundEventHandle : FocusOnEventHandle
    {
        public BattleButtonBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}