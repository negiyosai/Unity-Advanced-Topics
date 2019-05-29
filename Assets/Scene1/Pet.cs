using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string petName;

    protected virtual void Speak() {  //overrides any function that inherits from class Pet

        Debug.Log("Speak!");

    }

    private void Start()
    {
        Speak(); // this will run Speak method but first will check if any child inherited script is overriding, if overriding it runs the child inherited method
    }
}
