using System;
using UnityEngine;

namespace src.card_framework.abs
{
    public class AbsView
    {
        public int GameObjectLayer;
        public String RegisterName;
        public Vector3 LocalPosition;
        public Vector3 AbsPosition;
        public Sprite Sprite;
        public Vector3 AbsScale;
        public Vector3 LocalScale;
        public float SizeX;
        public float SizeY;
        public int AbsLayer;
        public int LocalLayer;
        public Vector3 AbsEulerAngles;
        public Vector3 LocalEulerAngles;
        public bool IsActive = true;
    }
}
