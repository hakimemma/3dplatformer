using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    float maxSpeed = 1.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    float rotationSpeed = 2.0f;
    float camRotationSpeed = 1.5f;
    GameObject cam;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }
    
    
    void Update()
    {
       transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);
       rotation = rotation + Input.GetAxis("Mouse X"); 
       transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));
       camRotation = camRotation + Input.GetAxis("mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }
}
