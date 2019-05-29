using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    
    void Start()
    {
        Event.onClick += Fall;
    }

    public void Fall()
    {

        GetComponent<Rigidbody>().useGravity = true;
    }

    
}
