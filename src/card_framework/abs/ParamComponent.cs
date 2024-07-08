using System;
using src.card_framework.@event;
using src.card_framework.render;
using UnityEngine;

namespace src.card_framework.abs
{
    public class ParamComponent : Nameable
    {
        protected AbsRender Render;
        protected AbsView View;
        protected AbsModel Model;
        protected DefaultEventHandle EventHandle;
    
        private bool _isActive;
        protected String Name;
        protected int id = 0;
        private String _registerName;

        private ComponentContainer _parent;
        public BaseComponent PreComponent { get; set; }
        public BaseComponent NextComponent { get; set; }

        public string GetName() {
            return this.Name;
        }
    
        public void SetName(String name) {
            this.Name = name;
        }

        public ComponentContainer GetParent()
        {
            return this._parent;
        }

        public void SetParent(ComponentContainer parent)
        {
            this._parent = parent;
            this.View.RegisterName = RegisterName();
        }
    
        public DefaultEventHandle GetEventHandle()
        {
            return this.EventHandle;
        }

        public string RegisterName()
        {
            if (_registerName == null)
            {
                if (_parent != null)
                {
                    _registerName = _parent.RegisterName() + "-" + GetName() + id;
                }
                else
                {
                    _registerName = GetName() + id;
                }
            }

            return _registerName;
        }
    
        public bool IsActive()
        {
            return _isActive;
        }

        public virtual void SetActive(bool isActive)
        {
            this.View.IsActive = isActive;
            this.Render.DoRender(View);
        }

        public int GetAbsLayer()
        {
            return this.View.AbsLayer;
        }

        public void SetAbsLayer(int absLayer)
        {
            this.View.AbsLayer = absLayer;
        }

        public virtual void SetLocalLayer(int layer)
        {
            this.View.LocalLayer = layer;

            if (_parent != null)
            {
                this.View.AbsLayer = _parent.GetAbsLayer() + layer;
            }
        }
    
        public Vector3 GetAbsPosition()
        {
            return this.View.AbsPosition;   
        }
    
        public void SetAbsPosition(Vector3 position)
        {
            this.View.AbsPosition = position;   
        }

        public Vector3 GetLocalPosition()
        {
            return this.View.LocalPosition;   
        }
    
        public virtual void SetLocalPosition(Vector3 position)
        {
            this.View.LocalPosition = position;
        
            if (_parent != null)
            {
                this.View.AbsPosition = _parent.GetAbsPosition() + position;
            }
        }

        public Vector3 GetAbsScale()
        {
            return this.View.AbsScale;
        }
    
        public void SetAbsScale(Vector3 absScale)
        {
            this.View.AbsScale = absScale;
        }

    
        public Vector3 GetLocalScale()
        {
            return this.View.LocalScale;
        }
    
        public virtual void SetLocalScale(Vector3 localScale)
        {
            this.View.LocalScale = localScale;
        
            if (_parent != null)
            {
                this.View.AbsScale = Vector3.Scale(_parent.GetAbsScale(), localScale);
            }
        }
    
        public Vector3 GetAbsEulerAngles()
        {
            return this.View.AbsEulerAngles;
        }

        public void SetAbsEulerAngles(Vector3 absEulerAngles)
        {
            this.View.AbsEulerAngles = absEulerAngles;
        }
    
    
        public Vector3 GetLocalEulerAngles()
        {
            return this.View.LocalEulerAngles;
        }
    
        public virtual void SetLocalEulerAngles(Vector3 localEulerAngles)
        {
            this.View.LocalEulerAngles = localEulerAngles;
        
            if (_parent != null)
            {
                this.View.AbsEulerAngles = _parent.GetAbsEulerAngles() + localEulerAngles;
            }
        }
    }
}