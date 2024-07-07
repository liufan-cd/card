using src.card_framework.abs;

namespace src.card_framework.@event
{
    public class BuildingPlaceBaseEventHandle : DefaultEventHandle
    {
        public BuildingPlaceBaseEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }
    }
}