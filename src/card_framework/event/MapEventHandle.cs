using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MapEventHandle : DefaultEventHandle
    {
        public MapEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}