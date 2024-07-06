using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MapBundlingEventHandle : DefaultEventHandle
    {
        public MapBundlingEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}