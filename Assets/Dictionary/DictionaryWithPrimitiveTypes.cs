using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryWithPrimitiveTypes : MonoBehaviour
{
    public Dictionary<string, int> people = new Dictionary<string, int>();

    public Dictionary<int, string> books = new Dictionary<int, string>();


    private void Start()
    {
       // NameAsKey();

        //NumberAsKey();

    }

    public void NameAsKey() {

        people.Add("Jon", 26);  //name and age
        people.Add("Rachel", 31);    //Rachel is the key and 31 is the value stored in it
        people.Add("Ross", 35);

        int rachelsAge = people["Rachel"];
        Debug.Log("Rachels Age:" + rachelsAge);
    }

    void NumberAsKey() {

        books.Add(0, "Harry Potter");
        books.Add(1, "LOTR");

        Debug.Log(books[1]); //this will print LOTR


        //BOTH OF THE BELOW FOREACH HAVE THE SAME OUTPUT

        foreach (KeyValuePair<int, string> book in books) {

            Debug.Log("Book: " + book.Value);  //Will print every books name
        }

        foreach (string book in books.Values) {

            Debug.Log("Book: " + book); 
        }

    }

   

}

