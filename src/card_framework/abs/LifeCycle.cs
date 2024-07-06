namespace src.card_framework.abs
{
    public interface LifeCycle {
        public abstract void Start();

        public abstract void Update(); 

        public abstract void FixUpdate();
    }
}