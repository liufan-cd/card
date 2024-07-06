using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class CloseIconEventHandle : DefaultEventHandle
    {
        public CloseIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}