using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleProgressBackgroundEventHandle : DefaultEventHandle
    {
        public BattleProgressBackgroundEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}