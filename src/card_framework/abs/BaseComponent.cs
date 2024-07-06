using System;
using System.Collections.Generic;
using src.card_framework.@event;
using src.card_framework.render;
using src.card_framework.util;

namespace src.card_framework.abs
{
    public abstract class BaseComponent : ParamComponent, LifeCycle, Activable
    {
        private int layer = 0;
        private long ticks;
        // 0 normal 1 mouse down for jude 2 do 
        private int status;
        protected int childrenCount = 1;
    
        public Dictionary<string, string> GetConfig()
        {
            Dictionary<string, string> config = LocalResourceLoaderUtil.GetConfig(this.GetName());

            if (config == null)
            {
                config = new Dictionary<string, string>();
                config.Add("path", this.GetName());    
            }

            return config;
        }

        public virtual void Start()
        {
            View.RegisterName = RegisterName();
            // init gameObject by view
            Render ??= new DefaultRender();
            Render.InitGameObject(View);
            BeanFactoryUtil.Register(this);
            EventHandle ??= new DefaultEventHandle(this);
        }

        public virtual void Update() {
            if (EventHandle.IsOnDrag())
            {
                EventHandle.OnDrag();
            }
        
            Render.DoRender(View);
        }

        public virtual void FixUpdate()
        {
        
        }

        public override string ToString()
        {
            return RegisterName();
        }

        public virtual int GetAllChildrenCount()
        {
            return this.childrenCount;
        }
    }
}