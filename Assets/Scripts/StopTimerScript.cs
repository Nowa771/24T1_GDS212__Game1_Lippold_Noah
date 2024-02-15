using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Timer timerScript = FindObjectOfType<Timer>();
            if (timerScript != null)
            {
                timerScript.StopTimer();
            }
        }
    }
}