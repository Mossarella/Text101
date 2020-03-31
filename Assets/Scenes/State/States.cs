using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class States : ScriptableObject
{
    [TextArea(14, 10)] public string storyText;
}
