using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public delegate void ActionClick();

    public static event ActionClick onClick;


    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;

    public void ButtonClick() {


       if (onClick!= null) // This checks if someone is listening which in our case are the cubes
        onClick(); 

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            if (onTeleport != null)
            {
                Vector3 pos = new Vector3(5, 2, 0);
                onTeleport(pos);
            }

        }
    }

}
