namespace src.card_framework.abs
{
    public interface ResourceLoadable<T> where T : AbsModelCreator {
    
        public abstract T GetResourceLoader();
    }
}