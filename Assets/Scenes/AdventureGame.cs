using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textBox;
    [SerializeField] State startingState;

    State currentState;
    //string[] daysOfTheWeek = { "Sun", "Mon", "Tues", "Wed", "Thu", "Fri", "Sat" };

    
    

    // Start is called before the first frame update
    void Start()
    {
        currentState = startingState;
        textBox.text = currentState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextState = currentState.GetNextStateStory();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = nextState[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentState = nextState[2];
        }
        textBox.text = currentState.GetStateStory();
    }
}
