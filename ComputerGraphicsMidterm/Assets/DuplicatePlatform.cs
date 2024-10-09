using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class DuplicatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject ground;

    void Start()
    {
        MeshFilter groundMeshFilter = ground.GetComponent<MeshFilter>();
        Mesh groundMesh = groundMeshFilter.mesh;
        for(int i = 0; i<100; i++){
            float instantiatePosX = ground.transform.position.x + ground.transform.lossyScale.x*(i+1);
            
            UnityEngine.Vector3 instantiatePos = platform.transform.position;
            instantiatePos.y = ground.transform.position.y;
            //instatiate platforms next to each other.
            instantiatePos.x = instantiatePosX;
            GameObject.Instantiate(platform).transform.position = instantiatePos;
        }
        
    }

    void Update()
    {
        
    }
}
