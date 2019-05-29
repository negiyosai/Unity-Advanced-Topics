using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DItemDatabase : MonoBehaviour
{
    public List<DItemClass> itemList = new List<DItemClass>();

    public Dictionary<int, DItemClass> itemDictionary = new Dictionary<int, DItemClass>(); // dictionary can call an element from the list by giving it a unique key

    private void Start()
    {
        //AddItem();
        //LoopThroughDictionary();
        //CheckIfDicionaryKeyExists();
       




    }

    void AddItem()
    {
        DItemClass sword = new DItemClass();
        sword.name = "Sword";
        sword.ID = 0;
        itemDictionary.Add(0, sword);

        var item = itemDictionary[0];

        Debug.Log(item.name); //outputs sword

    }

    void LoopThroughDictionary() {

        DItemClass sword = new DItemClass();
        sword.name = "Sword";
        sword.ID = 0;

        DItemClass bread = new DItemClass();
        bread.name = "Bread";
        bread.ID = 1;

        DItemClass cape = new DItemClass();
        cape.name = "Cape";
        cape.ID = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(0, bread);
        itemDictionary.Add(0, cape);

        foreach (KeyValuePair<int, DItemClass> item in itemDictionary)
        {


            Debug.Log("Key:" + item.Key);
            Debug.Log("Value:" + item.Value.name);


        }

        foreach (int key in itemDictionary.Keys)
        {

            Debug.Log("Key" + key);

        }

        foreach (DItemClass item in itemDictionary.Values)
        {

            Debug.Log("Item Name:" + item.name);

        }

    }

    void CheckIfDicionaryKeyExists()
    {

        if (itemDictionary.ContainsKey(60))
        {

            Debug.Log("You found the key");       // if(itemDictionary.ContainsKey(1)
            var randomItem = itemDictionary[60];  // var randomItem = itemDictionary[1]   will return You found the key as it exists as sword
        }
        else
        {
            Debug.Log("Key Does not exist");

        }



    }





}
