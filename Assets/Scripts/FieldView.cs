using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldView : MonoBehaviour
{
    Camera camera;
    [SerializeField] float scale;
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    
    void Update()
    {
        if(camera.fieldOfView >= 100)
        {
            camera.fieldOfView = 100;
        }
        if (camera.fieldOfView <= 40)
        {
            camera.fieldOfView = 40;
        }
        camera.fieldOfView += Input.mouseScrollDelta.y * scale;
        
    }
}
