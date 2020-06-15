using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
   [SerializeField] Text textComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "You have woken up from what feels like a long coma";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
