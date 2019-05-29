using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInterface : MonoBehaviour ,IDamagable// This wont work unless you make the properties that where in the original interface script

{
    public int Health { get; set; }
    public void Damage(int damageAmount) {

        GetComponent<MeshRenderer>().material.color = Color.red;
        Health -= damageAmount;
    }
    
}
