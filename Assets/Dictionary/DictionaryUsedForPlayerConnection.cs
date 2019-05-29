using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public string name;
    public int id;

    public Player(int id) {

        this.id = id;

    }


}

public class DictionaryUsedForPlayerConnection : MonoBehaviour
{

    public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();

    private void Start()
    {
        Player p1 = new Player(1);
        p1.name = "Jim";
        Player p2 = new Player(200);
        p2.name = "Kyle";
        Player p3 = new Player(35);
        p3.name = "Max";

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            var player = playerDictionary[200];
            Debug.Log(player.name); // this will print out kyle

        }
    }


}
