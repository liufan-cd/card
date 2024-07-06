using System;
using UnityEngine;

namespace src.card_framework.abs
{
    public abstract class AbsModel
    {
        public abstract AbsView GenerateView();
    
        public float SizeX;
        public float SizeY;
        public String Path;
        public Vector3 AbsPosition;
        public Vector3 LocalPosition;
        public Sprite Sprite;
        public Vector3 LocalScale;
        public int Layer;
    }
}
