using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "State", menuName = "Text101/State", order = 0)]
public class State : ScriptableObject 
{
    [TextArea(14,10)][SerializeField] string StoryText;
    [SerializeField] State[] nextState;
    
    public string GetStateStory()
    {
        return StoryText;
    }

    public State[] GetNextState()
    {
        return nextState;
    }
}