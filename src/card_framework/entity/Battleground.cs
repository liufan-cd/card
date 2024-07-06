using src.card_framework.abs;

namespace src.card_framework.entity
{
    public class Battleground : ComponentContainer
    {
        public Battleground () {
            this.SetName("battleground");
        }

        public override void BeforeChildrenStart()
        {
            // AddComponent(new GameMap());

            // for (int i = 0; i < 9; i++)
            // {
            // AddComponent(new DefaultComponent("building_drop_point", i));
            // }
        
            // AddComponent(new HandBackground());
            // AddComponent(new DefaultComponent("character_background"));
        }
    }
}