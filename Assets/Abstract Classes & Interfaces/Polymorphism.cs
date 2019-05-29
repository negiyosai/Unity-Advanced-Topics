using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
   
    void Update()
    {

        if (Input.GetMouseButton(0)) {

            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;

            if (Physics.Raycast(rayOrigin, out hitinfo)) {

                IDamagable obj = hitinfo.collider.GetComponent<IDamagable>();   //this will call the damage function in all scripts that uses the IDamagable interface
                if (obj != null) {

                    obj.Damage(500);
                }

            }
        }
        
    }
}
