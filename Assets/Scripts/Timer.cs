using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float timer;
    private bool isTimerRunning = false;

    void Start()
    {
        // Set initial time to 0
        timer = 0f;

        // Start the timer
        StartTimer();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // Update the timer
            timer += Time.deltaTime;

            // Format and display the timer
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        // Format the time as minutes:seconds:milliseconds
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = Mathf.Floor(timer % 60).ToString("00");
        string milliseconds = ((timer * 1000) % 1000).ToString("000");

        // Update the UI text
        timerText.text = $"{minutes}:{seconds}:{milliseconds}";
    }

    public void StartTimer()
    {
        // Set the flag to start the timer
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        // Set the flag to stop the timer
        isTimerRunning = false;
    }

    public void ResetTimer()
    {
        // Reset the timer to 0
        timer = 0f;

        // Update the UI text
        UpdateTimerText();
    }
}
