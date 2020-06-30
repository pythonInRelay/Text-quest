using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class AdventureGame : MonoBehaviour
{
   [SerializeField] private Text textComponent;
   [SerializeField] private State startingState;

   private State _state;
   
   // Start is called before the first frame update
    private void Start()
    {
        _state = startingState;
        textComponent.text = _state.GetStateStory();
        
    }

    // Update is called once per frame
    private void Update()
    {
        ManageState();
    }
    
    private void ManageState()
    {
        var nextStates = _state.GetNextStates();
        for (var index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                _state = nextStates[index];
            }
        }
        textComponent.text = _state.GetStateStory();
    }
}