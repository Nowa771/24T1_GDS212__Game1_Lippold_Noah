using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Timer timerScript; 

    private void Start()
    {
       
        timerScript.StartTimer();
    }
}