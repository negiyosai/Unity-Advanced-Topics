using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    //THIS INCLUDES IF SWITCH AND LOOPS


    [SerializeField]
    private Vector3 position;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Color colourOption;

    public Transform positionOfCube;

    private int Level;
    private int i;
  
    void Start()
    {
        //SnapToPosition();
        //PositionOfCube();
        //ChangeColor();
        //SwitchStatement();
        //BreakInForLoop();
        //StartCoroutine(IncrementiEverySecondUsingFor());
        //StartCoroutine(UsingWhileLoopForSpawning());
    }

    void Update()
    {
        Movement();
    }


    private void Movement()
    {
        // transform.Translate(Vector3.right * Time.deltaTime); 

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);
    }

    void SnapToPosition()
    {

        position = new Vector3(0, 0, 10);

        transform.position = position;
    }

    void PositionOfCube()
    {

        Debug.Log(positionOfCube.position.x);
    }

    void ChangeColor()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        this.gameObject.GetComponent<Renderer>().material.color = colourOption;

    }

    void SwitchStatement()
    {

        Level = Random.Range(0, 3); // only prints 0,1,2 as its int. If it was float than prints 0,1,2,3

        switch (Level)
        {

            case 0:
                Debug.Log("Level 0");
                break;
            case 1:
                Debug.Log("Level 1");
                break;
            case 2:
                Debug.Log("Level 2");
                break;
            default:
                Debug.Log("Error");
                break;
        }

    }

    void BreakInForLoop()
    {

        for (int i = 0; i < 100; i++)
        {

            Debug.Log(i);

            if (i == 50)
            {
                break;
            }

        }

        Debug.Log("Loop finished");

    }

    IEnumerator IncrementiEverySecondUsingFor()
    {

        for (int i = 0; i < 100; i++)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1f);

        }


    }

    IEnumerator UsingWhileLoopForSpawning()
    {

        while (i < 10)
        {

            i++;
            Debug.Log(i);
            yield return new WaitForSeconds(1f);

        }

    }


}
