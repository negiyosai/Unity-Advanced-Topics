using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public SpellClass[] spells;

    public int level = 1;
    public int exp;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){

            foreach (var s in spells) {

                if (s.levelRequired == level) {

                    s.Cast();
                    exp += s.expGained;
                }

            }

        }

    }
}
