using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
   private Camera _camera; 
   
    void Start()
    {
        _camera = Camera.main;
    }

    
    void LateUpdate()
    {
        transform.LookAt(_camera.transform);
    }
}
