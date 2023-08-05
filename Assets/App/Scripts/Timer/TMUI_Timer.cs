using System;
using System.Collections;
using System.Collections.Generic;
using App.Scripts.Timer;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class TMUI_Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TM_Timer timer;

    private void Awake()
    {
        timer.onSecondPassed.AddListener(UpdateTimerText);
    }
    
    private void UpdateTimerText()
    {
        var minutes = Mathf.Floor(timer.Timer / 60);
        var seconds = Mathf.Floor(timer.Timer % 60);
        AlertColorForTimer((int) timer.Timer);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
    
    private void AlertColorForTimer(int seconds)
    {
        if (seconds <= 15)
        {
            timerText.color = Color.red;
        }
        else
        {
            timerText.color = Color.white;
        }
    }
}
