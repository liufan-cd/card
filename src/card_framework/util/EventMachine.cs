using System;
using src.card_framework.abs;
using UnityEngine;

namespace src.card_framework.util
{
    public class EventMachine
    {
    
        private static RaycastHit hit;
    
        private static BaseComponent selectComponent;
        private static BaseComponent clickComponent;
    
        private static long ticks;
        // 0 normal 1 mouse down for jude 2 do
        private static int status;
        private static Vector3 mousePosition;
        private static Vector3 position;
    
        public static void CheckInput()
        {
            // Debug.Log("Input.mousePosition: " + Input.mousePosition);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Debug.Log("ray.origin): " + ray.origin);
            int mask = 1 << 7;
            RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, Vector2.zero,float.PositiveInfinity, mask);

            if (hit2D.collider != null)
            {
                UpdateStatus(hit2D);
            }
            else
            {
                if (Input.GetMouseButtonUp(0) && clickComponent != null)
                {
                    long mouseUpTicks = DateTime.Now.Ticks;
                    clickComponent.GetEventHandle().OnMouseUp();

                    if (status != 0)
                    {
                        if (mouseUpTicks - ticks < 2000000)
                        {
                            clickComponent.GetEventHandle().OnClick();
                        }
                        else
                        {
                            clickComponent.GetEventHandle().EndDrag();
                        }
                    }

                    status = 0;
                    clickComponent = null;
                }

                if (selectComponent != null)
                {
                    selectComponent.GetEventHandle().OnMouseMoveOut();   
                }

                selectComponent = null;
            }
        }

        private static void UpdateStatus(RaycastHit2D hit2D)
        {
            BaseComponent baseComponent = BeanFactoryUtil.Get(hit2D.collider.gameObject.name);
            bool down = Input.GetMouseButtonDown(0);
            bool up = Input.GetMouseButtonUp(0);

            if (status == 0)
            {
                // move in or move out
                if (baseComponent != selectComponent)
                {
                    if (selectComponent != null)
                    {
                        selectComponent.GetEventHandle().OnMouseMoveOut();
                    }

                    if (baseComponent != null)
                    {
                        baseComponent.GetEventHandle().OnMouseMoveIn();
                    }

                    selectComponent = baseComponent;
                }
            }

            // 
            if (down)
            {
                if (selectComponent != null)
                {
                    selectComponent.GetEventHandle().OnMouseMoveOut();
                    selectComponent = null;   
                }

                clickComponent = baseComponent;
                long mouseDownTicks = DateTime.Now.Ticks;

                if (status == 0)
                {
                    ticks = mouseDownTicks;
                    status = 1;
                    clickComponent.GetEventHandle().OnMouseDown();
                }
            }

            if (up)
            {
                long mouseUpTicks = DateTime.Now.Ticks;
                clickComponent.GetEventHandle().OnMouseUp();

                if (status != 0)
                {
                    if (mouseUpTicks - ticks < 2000000)
                    {
                        clickComponent.GetEventHandle().OnClick();
                    }
                    else
                    {
                        clickComponent.GetEventHandle().EndDrag();
                    }
                }

                status = 0;
                clickComponent = null;
            }
        }
    }
}