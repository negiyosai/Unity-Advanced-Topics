using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubeRotation : MonoBehaviour
{

    public GameObject Cube;
  
    void Start()
    {
        Instantiate(Cube, Vector3.zero, Quaternion.Euler(0, 35, 0)); // spawns the cube at an angle of 35 degree on the y axis
        Instantiate(Cube, new Vector3(-4, 0,0), Quaternion.identity); // spawns with rotation set to 0 in all axis
        
    }

    
}
