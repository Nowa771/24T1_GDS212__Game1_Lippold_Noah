using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText; 
    private float timer = 0f; 
    private bool isRunning = false; 
    private void Update()
    {
        if (isRunning)
        {
            
            timer += Time.deltaTime;

            
            UpdateTimerUI();
        }
    }

    public void StartTimer()
    {
        // Start the timer
        isRunning = true;
    }

    public void StopTimer()
    {
        // Stop the timer
        isRunning = false;
    }

    public void ResetTimer()
    {
        // Reset the timer
        timer = 0f;
        UpdateTimerUI();
    }

    private void UpdateTimerUI()
    {
        // Update UI text to display the timer
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        int milliseconds = Mathf.FloorToInt((timer * 1000) % 1000);

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}