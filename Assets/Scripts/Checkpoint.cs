using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Timer timerScript; 
    public bool isStartLine = false; 
    public bool isFinishLine = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (isStartLine)
            {
                timerScript.StartTimer();
            }
            
            if (isFinishLine)
            {
                timerScript.StopTimer();
            }
            
           
            
        }
    }
}