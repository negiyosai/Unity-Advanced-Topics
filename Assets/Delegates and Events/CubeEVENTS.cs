using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEVENTS : MonoBehaviour
{
    void Start()
    {

        Event.onClick += TurnRed;

        Event.onTeleport += Spawn;  
    }

    public void TurnRed() {

        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnDisable()
    {
        Event.onClick -= TurnRed;
        Event.onTeleport -= Spawn;
    }

    public void Spawn(Vector3 pos) //notice that the parameters are same as that of the delegates
    {
        transform.position = pos;

    }

}
