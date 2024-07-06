using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class HelpIconBorderEventHandle : FocusOnEventHandle
    {
        public HelpIconBorderEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}