using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpellClass 
{
    public string name;
    public int levelRequired;
    public int expGained;


    public SpellClass(string name, int lev, int exp) {

        this.name = name;
        this.levelRequired = lev;
        this.expGained = exp;

    }

    public void Cast() {

        Debug.Log("Cast Spell" + this.name);
    }
}
