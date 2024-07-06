using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleValueIconEventHandle : DefaultEventHandle
    {
        public BattleValueIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}