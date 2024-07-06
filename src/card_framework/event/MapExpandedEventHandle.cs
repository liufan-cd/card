using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MapExpandedEventHandle : DefaultEventHandle
    {
        public MapExpandedEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}