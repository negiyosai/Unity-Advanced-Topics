using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);  // this can only take in methods that have color parameter

    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete; 


    private void Start()
    {
        onColorChange = UpdateColor;
        onColorChange(Color.green);
        

        //onColorChange = Task; This will give an errror as you cannot assign onColorChange to a method that doesn't have the delegate paramater ie Color newColor in this case
        onComplete += Task;  // here the parameters match as there are no parameteres
        onComplete += Task2;
        onComplete += Task3; //this += stacks multiple methods in a single variable

        //onComplete -= Task3; // This Removes method

        if (onComplete != null) {

            onComplete();
        }



    }

    public void UpdateColor(Color newColor) {

       Debug.Log("Changing color to: " + newColor.ToString());
    }

    public void Task() {

       Debug.Log("Task 1 Finished");

    }
    public void Task2()
    {

        Debug.Log("Task 2 Finished");

    }
    public void Task3()
    {

        Debug.Log("Task 3 Finished");

    }

}
