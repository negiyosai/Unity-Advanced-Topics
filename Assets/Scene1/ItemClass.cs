using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemClass
{
    public string name;
    public int ID;
    public string description;

    public ItemClass(string name, int ID, string description) {

        this.name = name;
        this.ID = ID;
        this.description = description;

    }

}
