using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BuildingPlaceEventHandle : DefaultEventHandle
    {
        public BuildingPlaceEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}