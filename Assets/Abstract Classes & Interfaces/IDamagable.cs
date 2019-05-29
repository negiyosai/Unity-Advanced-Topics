using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable 
{
    //int health;  // This gives error as you cannnot contain fields in an interface

    int Health { get; set; }

    void Damage(int damageAmount);  

    //WHICHEVER SCRIPTS INHERITS THIS INTERFACE IT HAS TO IMPLEMENT BOTH INT HEALTH AND VOID DAMAGE TO WORK
   
   
}
