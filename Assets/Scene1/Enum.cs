using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    public enum LevelSelector {

        TROLL,     //0
        Normal,   //1     //this is the deafult order
        Hard,     //2   
        Expert    //3   
        //Veteran = 100; will hardcode value 100 into the variable

    }

    public LevelSelector currentLevel;


    void Start()
    {
       

        if (currentLevel == LevelSelector.Normal) {

            Debug.Log("You selected Normal");

        }

    }

   
}
