using src.card_framework.abs;

namespace src.card_framework.entity
{
    public class BattleBackground : ComponentContainer
    {
        public BattleBackground () {
            SetName("battle_background");
        }

        public override void BeforeChildrenStart()
        {
            
        }
    }
}