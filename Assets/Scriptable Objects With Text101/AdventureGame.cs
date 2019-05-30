using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    Text gameText;
    [SerializeField]
    State startingState; 

    State state;

    void Start()
    {
        state = startingState;
        gameText.text = state.GetStateStory();
    }

    private void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates(); //this stores the return
        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))  //this increases Alpha1 to Alpha 2 and so on
            {

                state = nextStates[i];  // this will remove the out of bound array error

            }

        }

        gameText.text = state.GetStateStory();
    }


}
