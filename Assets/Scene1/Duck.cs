using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Pet
{
    // This script can be attached to an object because it inherits Pet which inherits Monobehaviour 
    // Start is called before the first frame update

    //public void Speak() This Gives error as Speak method already exists in Pet
    // So we create a virtual method in Pet to override it

    protected override void Speak()
    {
        // base.Speak(); // this will call the method from the parent class

        Debug.Log("Quack");


    }


}
