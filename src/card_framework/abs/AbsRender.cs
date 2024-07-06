using src.card_framework.view;

namespace src.card_framework.abs
{
    public interface AbsRender {
        public abstract void InitGameObject(AbsView view);
        public abstract void DoRender(AbsView view);
        public abstract void CalculateScale(AbsView view);
    }
}