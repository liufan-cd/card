using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BuildingPlaceFaceEventHandle : DefaultEventHandle
    {
        public BuildingPlaceFaceEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}