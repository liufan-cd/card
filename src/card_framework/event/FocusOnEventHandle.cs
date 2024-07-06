using src.card_framework.abs;
using UnityEngine;

namespace src.card_framework.@event
{
    public class FocusOnEventHandle : DefaultEventHandle
    {
        public FocusOnEventHandle(BaseComponent target) : base(target)
        {
        }
    
        public override void OnMouseMoveIn()
        {
            Target.SetLocalScale(new Vector3(1.1f, 1.1f, 1));
        }

        public override void OnMouseMoveOut()
        {
            Target.SetLocalScale(new Vector3(1, 1, 1));
        }
    }
}