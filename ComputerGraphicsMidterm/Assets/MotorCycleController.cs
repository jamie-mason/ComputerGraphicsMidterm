using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class MotorCycleController : MonoBehaviour
{
    
    Rigidbody rb;
    public float accelerationModifier = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
       float posY = Mathf.Clamp(transform.position.y,0.0f,1000);
       transform.position = new UnityEngine.Vector3(transform.position.x, posY, 0f);
       transform.eulerAngles = new UnityEngine.Vector3(0f, 0f, 0f);
       float horizontal = Input.GetAxis("Horizontal");

       


       rb.AddForce(UnityEngine.Vector3.right * horizontal * accelerationModifier, ForceMode.Acceleration);
    }
    
    
    
}
