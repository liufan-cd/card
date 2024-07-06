using src.card_framework.abs;
using UnityEngine;

namespace src.card_framework.@event
{
    public class CardPlaceShadowEventHandle : DefaultEventHandle
    {
        private Vector3 offset;

        public CardPlaceShadowEventHandle(BaseComponent target) : base(target)
        {
            this.Target = target;
        }

        public override void OnMouseDown()
        {
            Draging = true;
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 targetPosition = Target.GetAbsPosition();
            offset = mousePosition - targetPosition;
        }

        public override void OnDrag()
        {
            float deltaTime = Time.deltaTime;
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
            Vector3 originPosition = Target.GetAbsPosition();
            targetPosition.z = 0;
            originPosition.z = 0;
            float distance = Vector3.Distance(originPosition, targetPosition);
            float speed = distance / deltaTime;
            speed = Mathf.Clamp(speed, 1.8f, 2.8f);
            float pow = 1 + distance;
            pow *= pow;
            speed *= pow;
            Vector3 arrow = targetPosition - originPosition;
            Vector3 direct = arrow.normalized;
            direct.z = 0;
            Target.SetAbsPosition(originPosition + direct * (speed * deltaTime));
            Vector3 eulerAngles = Target.GetLocalEulerAngles();

            float clamp;

            if (offset.y < 0)
            {
                clamp = Mathf.Min(offset.y, -1.8f);
            }
            else
            {
                clamp = Mathf.Max(offset.y, 1.8f);
            }
        
            clamp = Mathf.Clamp(-arrow.x * 1.8f * pow * clamp, -60f, 60f);
            Debug.Log(arrow.x);
        
            Target.SetLocalEulerAngles(new Vector3(eulerAngles.x, eulerAngles.y,
                clamp));
        }

        public override void EndDrag()
        {
            Draging = false;
        }
    }
}