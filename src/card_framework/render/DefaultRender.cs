using src.card_framework.abs;
using src.card_framework.util;
using src.card_framework.view;
using UnityEngine;

namespace src.card_framework.render
{
    public class DefaultRender : AbsRender
    {
        protected GameObject GameObject;
        protected SpriteRenderer Renderer;
        protected BoxCollider2D Collider;
        protected Transform Transform;

        public virtual void DoRender(AbsView view)
        {
            if (view.Sprite != null)
            {
                Renderer.sprite = view.Sprite;
                Transform.position = view.AbsPosition;
                Transform.localScale = view.AbsScale;
                Renderer.sortingOrder = view.AbsLayer;
                Transform.eulerAngles = view.AbsEulerAngles;
            }
            
            GameObject.SetActive(view.IsActive);
        }

        public void InitGameObject(AbsView view)
        {
            if (GameObject == null)
            {
                GameObject = new GameObject();
                Renderer = GameObject.AddComponent<SpriteRenderer>();
                Transform = GameObject.GetComponent<Transform>();
                Collider = GameObject.AddComponent<BoxCollider2D>();
            }
            
            if (view.Sprite != null)
            {
                Renderer.sprite = view.Sprite;
                Transform.position = view.AbsPosition;
                CalculateScale(view);
                Renderer.sortingOrder = view.AbsLayer;
                Collider.size = Renderer.size;
            }
            
            GameObject.name = view.RegisterName;
            GameObject.layer = view.GameObjectLayer;
        }

        public void CalculateScale(AbsView view)
        {
            if (view.Sprite != null)
            {
                float ratio = view.SizeX / Renderer.size.x;

                if (view.SizeY != 0)
                {
                    view.AbsScale = new Vector3(ratio * LocalConstant.GLOBAL_SCALE, view.SizeY / Renderer.size.y, 0);
                }
                else
                {
                    view.AbsScale = new Vector3(ratio * LocalConstant.GLOBAL_SCALE, ratio, 0);    
                }
            }
            
            Transform.localScale = view.AbsScale;
        }
        
    }
}