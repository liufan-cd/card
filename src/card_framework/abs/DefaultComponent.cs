using System;
using System.Collections.Generic;
using src.card_framework.model;
using src.card_framework.util;

namespace src.card_framework.abs
{
    public class DefaultComponent : BaseComponent
    {
        public DefaultComponent()
        {
        }

        public DefaultComponent(String name)
        {
            this.Name = name;
            Dictionary<string, string> config = LocalResourceLoaderUtil.GetConfig(this.GetName());

            if (config == null)
            {
                config = new Dictionary<string, string>();
                config.Add("path", this.Name);    
            }

            this.Model = new DefaultModel(config);
            this.View = Model.GenerateView();
        }
    
        public DefaultComponent(String name, int id)
        {
            this.Name = name;
            this.id = id;
        }

        public override void FixUpdate()
        {   
        
        }
    }
}