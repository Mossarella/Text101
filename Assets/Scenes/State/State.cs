using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] public string myStoryText;
    [SerializeField] State[] nextState;

    public string GetStateStory()
    {
        return myStoryText;
        
    }
    public State[] GetNextStateStory()
    {
        return nextState;
    }
}
