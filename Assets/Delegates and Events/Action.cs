using System; //This is used to access the Action function
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{

    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage; // this is delegate and event system

    public static Action<int> onDamageReceived; // This works the same as the delegate above //static is added so that it is accessable from other scripts
    public int Health;

    void Start()
    {

        Health = 10;
        //Damage(); // This needs to be called for the Debug.Log in UI manager to work!
    }

    void Damage() {

        Health--;
        if (onDamageReceived != null)
            onDamageReceived(Health);

    }

 
}
