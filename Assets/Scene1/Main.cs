using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
  
   
    void Update()
    {

        Pause();

    }

    void Pause() {

        if (Input.GetKeyDown(KeyCode.P))
        {

            Time.timeScale = 0f;
        }

        else if (Input.GetKeyDown(KeyCode.R)) {

            Time.timeScale = 1f;
        }

    }

    void InputPresses() {

        // is space pressed down 
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("space");

        }

        // e is held down
        if (Input.GetKey(KeyCode.E))
        {

            Debug.Log("E HELD");
        }

        // f is lifted up
        if (Input.GetKeyUp(KeyCode.F))
        {

            Debug.Log("F IS LIFTED");
        }

    }




}
