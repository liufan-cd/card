using src.card_framework.abs;
using UnityEngine;

namespace src.card_framework.@event
{
    public class DefaultEventHandle
    {
        protected BaseComponent Target;
        protected Vector3 MousePosition;
        protected Vector3 Position;
        protected bool Draging = false;

        public DefaultEventHandle(BaseComponent target)
        {
            this.Target = target;
        }

        public virtual void OnMouseMoveIn()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().OnMouseMoveIn();
            }
        }
    
        public virtual void OnMouseMoveOut()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().OnMouseMoveOut();
            }
        }
    
        public virtual void OnMouseDown()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().OnMouseDown();
            }
        }
    
        public virtual void OnMouseUp()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().OnMouseUp();
            }
        }

        public virtual void OnClick()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().OnClick();
            }
        }
    
        public virtual void OnDrag()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().OnDrag();
            }
        }
    
        public virtual void EndDrag()
        {
            if (Target.GetParent() != null)
            {
                Target.GetParent().GetEventHandle().EndDrag();
            }
        }

        public virtual bool IsOnDrag()
        {
            if (Target.GetParent() != null)
            {
                return Target.GetParent().GetEventHandle().IsOnDrag();
            }

            return Draging;
        }
    }
}