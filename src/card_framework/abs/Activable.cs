namespace src.card_framework.abs
{
    public interface Activable {
        public abstract bool IsActive();

        public abstract void SetActive(bool isActive);
    }
}