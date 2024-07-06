using src.card_framework.abs;

namespace src.card_framework.entity
{
    public class MainBackground : ComponentContainer
    {
        public MainBackground () {
            this.SetName("main_background");
        }

        public override void BeforeChildrenStart()
        {
            AddComponent(new Battleground());
        }
    }
}