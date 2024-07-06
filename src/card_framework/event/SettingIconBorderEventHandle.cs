using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class SettingIconBorderEventHandle : FocusOnEventHandle
    {
        public SettingIconBorderEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}