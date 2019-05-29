using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour  //abstract class can't be attached to object
{
    public int speed;
    public int health;

    public abstract void Attack(); // this makes the class inherting this enemy class use this method absolutely (forced implementation) otherwise it will give an error
   

}

public class Giant : Enemy {

    public override void Attack()  // the inherited class has to use this method from the base class otherwise it won't work
    {
        throw new System.NotImplementedException();
    }

}
