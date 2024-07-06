using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class HelpIconEventHandle : DefaultEventHandle
    {
        public HelpIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}