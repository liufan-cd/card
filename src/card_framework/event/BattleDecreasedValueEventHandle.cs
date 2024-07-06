using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleDecreasedValueEventHandle : DefaultEventHandle
    {
        public BattleDecreasedValueEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}