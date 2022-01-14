using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    State state;
    int[] oddNumbers= {1,3,5,7,9};
    string[] weekDays={"Sunday","Monday","Tuesday","Wedensday","Thursday","Friday","Saturday"};
    void Start()
    {
        state=startingState;
        textComponent.text=state.GetStateStory();
        
        Debug.Log(oddNumbers[3]);
        Debug.Log(weekDays[2]);
    }

    
    void Update()
    {
        ManageStates();
    }

    private void ManageStates()
    {
        var nextStates=state.GetNextState();

        for(int index=0;index<nextStates.Length;index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1+index))
            {
                state=nextStates[index];
            }
        }

        // if(Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     state=nextStates[0];
        // }

        // else if(Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     state=nextStates[1];
        // }

        // else if(Input.GetKeyDown(KeyCode.Alpha3))
        // {
        //     state=nextStates[2];
        // }

        textComponent.text=state.GetStateStory();
    }
}
