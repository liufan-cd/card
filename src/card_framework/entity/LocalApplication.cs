using System;
using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.util;
using UnityEngine;

namespace src.card_framework.entity
{
    public class LocalApplication : MonoBehaviour
    {
        private ComponentContainer componentContainer;
        private GameObject cameraGameObject;
        private Camera camera;
    
        // Start is called before the first frame update
        void Start()
        {
            LocalResourceLoaderUtil.LoadSystemResource();
            cameraGameObject = new GameObject();
            camera = cameraGameObject.AddComponent<Camera>();
            camera.orthographic = true;
            cameraGameObject.transform.position = new Vector3(0, 0, -100);
            camera.orthographicSize = 5.4f;
            cameraGameObject.tag = "MainCamera";
            // LocalConstant.GLOBAL_SCALE = 1;
            // load by properties
            camera.aspect = 1920f / 1080f;
            LocalConstant.GLOBAL_SCALE = 10.8f / 19.20f * camera.aspect;
            this.componentContainer = new MainBackground1();
            // this.componentContainer = new HandBackground();
            HashSet<String> set = new HashSet<string>();
            componentContainer.Start();
        }

        // Update is called once per frame
        void Update()
        {
            EventMachine.CheckInput();
            componentContainer.Update();
        }

        private void FixedUpdate()
        {
            componentContainer.FixUpdate();
        }
    }
}
