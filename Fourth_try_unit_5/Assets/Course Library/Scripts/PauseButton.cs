using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  
public class PauseButton : MonoBehaviour 
{
    //give the game a possible pause for the player to take a breather, using TIMESCALE.
    void Start() 
    {
        GetComponent<Button>().onClick.AddListener(TogglePause);
    }
     
        public void TogglePause() 
    {
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;        
    }
}