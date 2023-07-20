using System;
using System.Collections;
using System.Collections.Generic;
using App.Scripts.Timer;
using TMPro;
using UnityEngine;

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
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
}
