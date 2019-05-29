using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour
{
    private void Start()
    {
        GetStaticScore();
    }


    void GetStaticScore() {

        ScoreStaticVariable.score = 10; // here we get the score from the ScoreStaticVariable script without any instance or reference since it is a stati variable
    }
}
