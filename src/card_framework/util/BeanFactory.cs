using System;
using System.Collections.Generic;
using src.card_framework.abs;

namespace src.card_framework.util
{
    public class BeanFactoryUtil
    {
        private static readonly Dictionary<String, BaseComponent> Dictionary = new();

        public static T GetInstance<T>() where T : BaseComponent,new()
        {
            T baseComponent = new T();
            return baseComponent;
        }
    
        public static void Register(BaseComponent component)
        {
            if (!Dictionary.ContainsKey(component.RegisterName()))
            {
                Dictionary.Add(component.RegisterName(), component);   
            }
        }
        
        public static BaseComponent Get(String name)
        {
            return Dictionary[name];
        }
    }
}