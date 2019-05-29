using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInheritance 

{
    public string name;
    public int ItemId;
    public Sprite icon;

    private string privateName; //this variable cannot be accessed by the inherited scripts
    protected string protectedName; // this variable can only be accessed by scripts that inherit this class ie ItemInheritance
    public string publicName; //this variable can be accessed anywhere
}
