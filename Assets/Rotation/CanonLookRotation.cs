using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonLookRotation : MonoBehaviour
{
    [SerializeField]
    private Transform sphere;

    void Update()
    {

        //SnapToRotation();
        LerpRotation();

    }

    void SnapToRotation() {

        //directoin = destination - source;
        Vector3 directionToFace = sphere.position - this.gameObject.transform.position; //or simply transform.rotation as it will get the rotation of the object with which the script is attached

        Debug.DrawRay(transform.position, directionToFace, Color.red);  //Debug.DrawRay(source(this gameobject), destination(sphere))

        this.gameObject.transform.rotation = Quaternion.LookRotation(directionToFace);
    }

    void LerpRotation() {
        //directoin = destination - source;
        Vector3 directionToFace = sphere.position - this.gameObject.transform.position; //or simply transform.rotation as it will get the rotation of the object with which the script is attached

        Debug.DrawRay(transform.position, directionToFace, Color.red);  //Debug.DrawRay(source(this gameobject), destination(sphere))

        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        this.gameObject.transform.rotation = Quaternion.Slerp(this.gameObject.transform.rotation, targetRotation, Time.deltaTime);
                                             
    }

}
