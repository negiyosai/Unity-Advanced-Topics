using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeaponStats {

    
    public string name;
    public float fireRate;
    public int Ammo;

    public WeaponStats(string name, float fireRate, int Ammo) {  // This is called a constructor

        this.name = name;         // this.name refers to the public string name above
        this.fireRate = fireRate;
        this.Ammo = Ammo;

    }

}

public class Player3ClassExample : MonoBehaviour
{

    private WeaponStats blasters;

    void Start()
    {

        blasters = new WeaponStats("Blasters", 0.25f, 500);
        Debug.Log("Name of Weapon :" +blasters.name);
        Debug.Log(blasters.fireRate);
        Debug.Log(blasters.Ammo);


    }
    
    void Update()
    {
        
    }

}
