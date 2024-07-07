using System;
using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.util;
using UnityEngine;

namespace src.card_framework.model
{
    public class DefaultModel : AbsModel
    {
        public DefaultModel () {

        }
        public DefaultModel (Dictionary<string, string> config) {
            this.Path = config["path"];
            this.Sprite = LocalResourceLoaderUtil.GetLoader().LoadSprite(this.Path);

            if (Sprite != null)
            {
                float positionX = config.TryGetValue("position_x", out String value) ? float.Parse(value) : 0;
                float positionY = config.TryGetValue("position_y", out value) ? float.Parse(value) : 0;
                float sizeX = config.ContainsKey("size_x") ? float.Parse(config["size_x"]) : 1;
                float sizeY = config.ContainsKey("size_y") ? float.Parse(config["size_y"]) : 0;
                this.AbsPosition = new Vector3(positionX, positionY, 0);
                this.LocalScale = new Vector3(1, 1, 1);
                this.SizeX = sizeX;
                this.SizeY = sizeY;
            }
        }

        public virtual AbsView CreateViewOrigin()
        {
            return new AbsView();
        }

        public override AbsView GenerateView()
        {
            AbsView view = CreateViewOrigin();
            view.Sprite = Sprite;
            view.LocalPosition = LocalPosition;
            view.AbsPosition = AbsPosition;
            view.LocalScale = LocalScale;
            view.LocalLayer = Layer;
            view.SizeX = SizeX;
            view.SizeY = SizeY;
            return view;
        }
    }
}