namespace src.card_framework.abs
{
    public abstract class AbsGround : ComponentContainer, Calculable
    {
        private AbsCalculator _calculator;

        public AbsCalculator GetCalculator()
        {
            throw new System.NotImplementedException();
        }

        public override void FixUpdate() {
            this.GetCalculator().DoCalculate(this);
        }
    }
}