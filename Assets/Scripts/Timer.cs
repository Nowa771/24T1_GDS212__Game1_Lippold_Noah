using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
        Invoke("ChangeScene", 3f); // Delay the scene change 
    }

    public void ResetTimer()
    {
        timer = 0f;
        UpdateTimerUI();
    }

    private void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        int milliseconds = Mathf.FloorToInt((timer * 1000) % 1000);

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Win Scene");
    }
}
