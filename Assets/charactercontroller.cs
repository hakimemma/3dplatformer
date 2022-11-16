using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{   float maxSpeed = 0.00001f;
    float roatationSpeed = 2.0f;
    float camRotation = 1.5f;
    GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }
    
    void Update()
    {
       transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);
       roatation = roatation + Input.GetAxis("Mouse X"); * rotationSpeed;
       transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));
       camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed; 
       
    }
}
