using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MainBackground1 : ComponentContainer
    {
        public MainBackground1 () {
            this.SetName("main_background1");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MainBackground1Model(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
            // this.AddComponent(new MainBackground2());
            // this.AddComponent(new MainBackground3());
            // this.AddComponent(new MainBorder1());
            // this.AddComponent(new MainBorder2());
            // this.AddComponent(new MainBorder3());
            // this.AddComponent(new MainBorder4());
            // this.AddComponent(new RemainsBackgroundShadow());
            // this.AddComponent(new CharacterIconShadow());
            // this.AddComponent(new SettingIconBorder());
            // this.AddComponent(new CloseIconBorder());
            // this.AddComponent(new HelpIconBorder());
            // this.AddComponent(new HandBackground());
            // this.AddComponent(new DrawingPileBackground());
            // this.AddComponent(new DiscardPileBackground());
            // this.AddComponent(new NextDayButton());
            // this.AddComponent(new MapShadow());
            // this.AddComponent(new BattleProgressBackground());
            // this.AddComponent(new BattleButtonBackground());
            // this.AddComponent(new BattleValueBackground());
            
            AddComponent(new CardBelowRedCard());
            AddComponent(new CardUpperBackground());
            AddComponent(new CardUpperRarityWhiteIcon());
            AddComponent(new CardUpperFace());
            AddComponent(new CardUpperPropIcon());
            AddComponent(new NumericalSlot());
        }
    }
}