using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateTEST")] // Now when you right click on the unity project space you will see this option along with c# script, material etc
public class State : ScriptableObject
{

    [TextArea(14, 10)] [SerializeField] string storyText;

    [SerializeField]
    State[] nextStates; //Declaring array of type State 

    int[] list;

    public string GetStateStory() {

        return storyText;

    }
     
    public State[] GetNextStates()  //array method
    { 
        return nextStates; // reutrn array to arry method
    }

    




}
 