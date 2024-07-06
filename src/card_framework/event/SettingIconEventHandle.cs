using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class SettingIconEventHandle : DefaultEventHandle
    {
        public SettingIconEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}