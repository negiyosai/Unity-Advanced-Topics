using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    public List<string> names = new List<string>(); //this creates a list that can be dynamically edited


    void Start()
    {

        foreach (var name in names) {

            Debug.Log(name);
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            var nameToRemove = names[Random.Range(0, names.Count)];

            names.Remove(nameToRemove); // names.length for arrays

            Debug.Log("Name Removed: " + nameToRemove);
        }
    }
}
