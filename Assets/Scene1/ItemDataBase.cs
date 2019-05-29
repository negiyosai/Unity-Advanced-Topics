using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public ItemClass[] items;
   
    void Start()   
    {


        items[0] = new ItemClass("Sword", 1, "Magical Sword");
     


    }

    private ItemClass CreateItem(string name, int ID, string description) {

        var item = new ItemClass(name, ID, description);

        return item;
    }
}
