using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class MapShadowEventHandle : FocusOnEventHandle
    {
        public MapShadowEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}