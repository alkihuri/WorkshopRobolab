using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCameraUIement : MonoBehaviour
{
     
    void Update()
    {
        transform.LookAt(Camera.main.transform.position + Camera.main.transform.forward * 100);
        
    }
}
