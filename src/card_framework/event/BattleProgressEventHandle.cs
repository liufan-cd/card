using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BattleProgressEventHandle : DefaultEventHandle
    {
        public BattleProgressEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}