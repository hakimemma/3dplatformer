using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float maxspeed = 0.00001f;
    float roatation = 0.0f;
    void Update()
    {
       transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical"));
       roatation = roatation + Input.GetAxis("Mouse X"); 
       transform.rotation = Quaternion.Euler(new Vector3(0.0f, roatation, 0.0f));
    }
}
