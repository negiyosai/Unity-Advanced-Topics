using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterface : MonoBehaviour, IDamagable, IShoot<int> // Multiple interfaces can be inherited but multiple classes cannot be //Also the <int> can be float too 
{
    public int Health { get; set; }

    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot(int ammo) {  // this int should be the same as the IShoot<int>

    }
   
}
