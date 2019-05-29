using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyVariables : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver { // this can make the bool only a get or set value so that it cannot be changed by anyone else
                             // if it was only get here we wouldn't be able to set the value of the bool and isGameOver = true/false would give an error

        get {

            return isGameOver;
        }

        set {

            if (value == true) {

                Debug.Log("The Game is Over");
            }

            isGameOver = value;
        }

    }

    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G)) {

            IsGameOver = true; //capital IsGameOver ie this is the property variable

        }
        
    }
}
