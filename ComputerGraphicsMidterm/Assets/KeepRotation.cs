using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeepRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.Vector3 offset;
    GameObject player;
    Camera cam;
    void Start()
    {
        player =GameObject.FindWithTag("Player");
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = UnityEngine.Vector3.zero;
        transform.position = player.transform.position + offset;
        
    }
    void FixedUpdate(){
        cam.transform.LookAt(player.transform.position);

    }
}
