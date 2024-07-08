using System;
using System.Collections.Generic;
using UnityEngine;

namespace src.card_framework.abs
{
    public abstract class ComponentContainer : BaseComponent, Register<BaseComponent>
    {

        protected readonly Dictionary<String, BaseComponent> Children = new();
        private bool _needResortLayer = true;
        protected readonly BaseComponent Root = new DefaultComponent();

        protected ComponentContainer()
        {
            ChainNode(Root,Root);
        }

        public void AddComponent(BaseComponent component)
        {
            component.SetParent(this);
            Children.Add(component.RegisterName(), component);
            ChainNode(Root.PreComponent, component);
            ChainNode(component, Root);
        }

        public bool ContainComponent(String childName)
        {
            return Children.ContainsKey(childName);
        }

        public IEnumerable<BaseComponent> GetIterator()
        {
            throw new NotImplementedException();
        }

        public BaseComponent RemoveComponent(string childName)
        {
            BaseComponent component = Children[childName];
            Children.Remove(childName);
            ChainNode(component.PreComponent, component.NextComponent);
            return component;
        }

        public override void Start()
        {
            base.Start();
            this.BeforeChildrenStart();
        
            foreach (BaseComponent item in Children.Values)
            {
                item.Start();
            }

            this.AfterChildrenStart();
        }

        public virtual void BeforeChildrenStart()
        {
        
        }
    
        
        public virtual void AfterChildrenStart()
        {
        
        }

        public void DoSortLayer()
        {
            int layerOffset = 1;
            BaseComponent item = Root;

            while ((item = item.NextComponent) != Root)
            {
                int count = item.GetAllChildrenCount();
                item.SetLocalLayer(layerOffset);
                layerOffset += count;
            }
        }

        public override int GetAllChildrenCount()
        {
            if (this.Children.Count != 0 && childrenCount == 1)
            {
                foreach (BaseComponent child in Children.Values)
                {
                    this.childrenCount += child.GetAllChildrenCount();
                }
            }

            return this.childrenCount;
        }
    
        public int GetChildrenCount()
        {
            return Children.Count;
        }

        public override void SetLocalLayer(int layer)
        {
            base.SetLocalLayer(layer);
            this._needResortLayer = true;
        }

        public override void Update()
        {
            base.Update();
            this.BeforeChildrenUpdate();

            if (_needResortLayer)
            {
                this.DoSortLayer();
                _needResortLayer = false;
            }
        
            foreach (BaseComponent item in Children.Values)
            {
                item.Update();
            }
        }

        public virtual void BeforeChildrenUpdate()
        {
        
        }

        public override void SetLocalPosition(Vector3 position)
        {
            base.SetLocalPosition(position);
        
            foreach (BaseComponent item in Children.Values)
            {
                item.SetAbsPosition(item.GetLocalPosition() + this.GetAbsPosition());
            }
        }

        public override void SetLocalScale(Vector3 scale)
        {
            SetAbsScale(scale);
        
            foreach (BaseComponent item in Children.Values)
            {
                item.SetAbsScale(Vector3.Scale(item.GetLocalScale(), this.GetAbsScale()));
            }
        }

        public override void SetActive(bool isActive)
        {
            base.SetActive(isActive);
        
            foreach (BaseComponent child in Children.Values)
            {
                child.SetActive(isActive);
            }
        }

        public override void FixUpdate()
        {
            this.LocalFixUpdate();
            foreach (BaseComponent item in Children.Values)
            {
                item.FixUpdate();
            }
        }

        public virtual void LocalFixUpdate()
        {
        
        }

        public void ResortLayer(BaseComponent component)
        {
            if (Children.ContainsKey(component.RegisterName()))
            {
                ChainNode(component.PreComponent, component.NextComponent);
                ChainNode(Root.PreComponent, component);
                ChainNode(component, Root);
            }
        
            DoSortLayer();
        }

        public void ChainNode(BaseComponent pre, BaseComponent next)
        {
            pre.NextComponent = next;
            next.PreComponent = pre;
        }
    }
}