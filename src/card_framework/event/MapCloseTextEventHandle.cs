using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MapCloseTextEventHandle : DefaultEventHandle
    {
        public MapCloseTextEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}