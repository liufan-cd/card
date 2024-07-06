using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CloseIconBorderEventHandle : FocusOnEventHandle
    {
        public CloseIconBorderEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}