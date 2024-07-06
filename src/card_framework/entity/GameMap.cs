using src.card_framework.abs;

namespace src.card_framework.entity
{
    public class GameMap : ComponentContainer
    {
        public GameMap()
        {
            this.SetName("map_container");
        }

        public override void BeforeChildrenStart()
        {
            AddComponent(new DefaultComponent("map_expanded"));
            AddComponent(new DefaultComponent("map_folded"));
        }
    }
}