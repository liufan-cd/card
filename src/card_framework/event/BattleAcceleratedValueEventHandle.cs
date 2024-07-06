using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleAcceleratedValueEventHandle : DefaultEventHandle
    {
        public BattleAcceleratedValueEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}