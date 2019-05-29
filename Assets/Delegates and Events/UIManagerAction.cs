using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerAction : MonoBehaviour
{

    public void OnEnable()
    {
        Action.onDamageReceived += UpdateHealth;  // this subscribes to the Action 
    }

    public void UpdateHealth(int health) {

        Debug.Log("Current Health:" + health);

    }

}
