using System;
using src.card_framework.abs;
using src.card_framework.entity;
using src.card_framework.util;
using UnityEngine;

namespace src.card_framework.@event
{
    public class CardContainerEventHandle : DefaultEventHandle
    {
        
        private BuildingPlace building;
        private Vector3 targetOriginPosition;
        private CardPlaceArrows arrows;
        protected CardContainer Target;

        public CardContainerEventHandle(CardContainer target) : base(target)
        {
            Target = target;
        }
    
        public override void OnMouseDown()
        {
            Draging = true;
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetOriginPosition = Target.GetAbsPosition();
            Target.SetOffset(mousePosition - targetOriginPosition);
        }

        public override void OnDrag()
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(worldPoint);

            if (worldPoint.y < -2)
            {
                Target.SetAbsPosition(worldPoint);
                Vector3 eulerAngles = Target.GetLocalEulerAngles();
                Target.SetLocalEulerAngles(new Vector3(eulerAngles.x, eulerAngles.y, 0));
                Target.SetLocalLayer(999);
            }
            else
            {
                Target.SetAbsPosition(targetOriginPosition + Vector3.up);
                Vector3 eulerAngles = Target.GetLocalEulerAngles();
                Target.SetLocalEulerAngles(new Vector3(eulerAngles.x, eulerAngles.y, 0));
            
            
            
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                int mask = 1 << 8;
                RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, Vector2.zero,float.PositiveInfinity, mask);

                if (hit2D.collider != null)
                {
                    BaseComponent baseComponent = BeanFactoryUtil.Get(hit2D.collider.gameObject.name);

                    if (baseComponent != null)
                    {
                        Vector3 point = worldPoint;
                        point.z = 0;

                        if (building == null)
                        {
                            building = BeanFactoryUtil.GetInstance<BuildingPlace>();
                            Target.AddComponent(building);
                            building.Start();
                            Target.GetParent()?.DoSortLayer();
                            Target.ResortLayer(building);

                            arrows = new CardPlaceArrows();
                            Target.AddComponent(arrows);
                            arrows.Start();
                            Target.GetParent()?.DoSortLayer();
                            Target.ResortLayer(arrows);
                        }
                        else
                        {
                            if (!Target.ContainComponent(building.RegisterName()))
                            {
                                building.SetActive(true);
                                Target.AddComponent(building);
                                Target.GetParent()?.DoSortLayer();
                                Target.ResortLayer(building);
                            }
                        
                            if (!Target.ContainComponent(arrows.RegisterName()))
                            {
                                arrows.SetActive(true);
                                Target.AddComponent(arrows);
                                Target.GetParent()?.DoSortLayer();
                                Target.ResortLayer(arrows);
                            }
                        }
                
                        building.SetAbsPosition(point);
                        Vector3 cardPosition = targetOriginPosition + Vector3.up;
                        arrows.SetAbsPosition((point + cardPosition) / 2);
                        arrows.SetSize(new Vector2(cardPosition.x - point.x, (point.y - cardPosition.y) * 2f));
                    }
                }
            }
        }

        public override void EndDrag()
        {
            Draging = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            int mask = 1 << 8;
            RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, Vector2.zero,float.PositiveInfinity, mask);

            if (building == null)
            {
                Target.SetOffset(Vector3.zero);
            }
            else
            {
                if (hit2D.collider != null)
                {
                    BaseComponent baseComponent = BeanFactoryUtil.Get(hit2D.collider.gameObject.name);

                    if (baseComponent is ComponentContainer container)
                    {
                        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        point.z = 0;
                        Building building = new Building(container.GetChildrenCount() + 1, point, container);
                        container.AddComponent(building);
                        building.Start();
                    
                        Target.SetOffset(Vector3.zero);
                        Target.GetParent().RemoveComponent(Target.RegisterName());
                        Target.SetActive(false);
                    
                        if (container.GetParent() != null)
                        {
                            container.GetParent().DoSortLayer();
                        }

                        container.ResortLayer(building);
                    }
                }

                Target.RemoveComponent(building.RegisterName());
                Target.RemoveComponent(arrows.RegisterName());
                building.SetActive(false);
                arrows.SetActive(false);
            }
            
            Target.GetParent().DoSortLayer();
        }

        public override void OnClick()
        {
            Draging = false;
            Target.SetOffset(Vector3.zero);
            Target.GetParent().DoSortLayer();
        }

        public override bool IsOnDrag()
        {
            return Draging;
        }
    }
}