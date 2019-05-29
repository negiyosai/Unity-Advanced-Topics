using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShoot<T> // this makes the interface generic so 
{
    void Shoot(T ammo); // this T can now be changed in the script that inherits this interface to any data type
 
}
