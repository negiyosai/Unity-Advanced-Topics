using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    //THIS INCLUDES ARRAYS METHODS FUNCTIONS AND PARAMETERS


    public string[] names;

    public int[] numbers = new int[] { 23, 5, 61, 34 };

    public GameObject[] cubes;

    int health;

    int total;

    void Start()
    {
        //CallArray();
        //ForLoopArray();
        //ForEachLoop();
        //ChangeColorOfAllCubes();
        //Sum(5, 2);
        //Damage(5); // Decreases health by 5
        //ChangeColourOfOneCube(cubes[1], Color.green);
        //total = SumReturnMethod(2, 6); // this returns 8 and puts that value inside total so total = 8 now. 
        //ChangePosition(new Vector3(0, 4, 6));
        //transform.position = GetPosition(5, 1, 0);
        //cubes = GetallCubes();

    }

    private void Update()
    {

    }

    

    private void CallArray() {

        //names[0] = "DIVINOS";

        Debug.Log(names[0]);
        Debug.Log(numbers[2]);

        int randomname = Random.Range(0, names.Length);

        Debug.Log(names[randomname]);
    }

    private void ForLoopArray() {

        for (int i = 0; i < names.Length; i++) {

            Debug.Log(names[i]);


        }

    }

    private void ForEachLoop()
    {

        foreach (var nameVariable in names)
        {

            Debug.Log(nameVariable);   // this prints out all the names in the names array

        }

    }

    private void ChangeColorOfAllCubes()
    {

        foreach (var cubeVariable in cubes)
        {

            cubeVariable.GetComponent<MeshRenderer>().material.color = Color.green;

        }

    }

    private void Sum(int a, int b)
    {

        Debug.Log(a + b); //prints output 7

    }

    private void Damage(int damageAmount)
    {

        health -= damageAmount;
    }

    private void ChangeColourOfOneCube(GameObject obj, Color colorToAssign)
    {

        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;

    }

    private int SumReturnMethod(int a, int b)
    {

        return a + b;

    }

    public void ChangePosition(Vector3 pos) {

        transform.position = pos;
    }

    public Vector3 GetPosition(float x, float y, float z)
    {

        Vector3 pos = new Vector3(x, y, z);

        return pos;

    }

    private GameObject[] GetallCubes() {

        cubes = GameObject.FindGameObjectsWithTag("Player");

        foreach (var p in cubes) {

            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

        }

        return cubes;

    }

}
