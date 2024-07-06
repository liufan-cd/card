using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MapCloseButtonEventHandle : DefaultEventHandle
    {
        public MapCloseButtonEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}