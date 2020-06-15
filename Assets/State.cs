using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class NewBehaviourScript : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string storyText;
    
}
