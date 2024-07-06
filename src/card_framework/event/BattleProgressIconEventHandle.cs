using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleProgressIconEventHandle : DefaultEventHandle
    {
        public BattleProgressIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}