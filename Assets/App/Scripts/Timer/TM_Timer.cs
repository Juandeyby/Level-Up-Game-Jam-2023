using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace App.Scripts.Timer
{
    public class TM_Timer : MonoBehaviour
    {
        [SerializeField] private int minutes = 1;
        [SerializeField] private int seconds = 30;
        public UnityEvent onTimerEnd;
        public UnityEvent onSecondPassed;
        public int miniGameID = 0;

        public string music = "event:/Music/Music";
        FMOD.Studio.EventInstance musicEvent;

        public string timerSound = "event:/SFX/Canvas/Timer Ends";
        FMOD.Studio.EventInstance timerEvent;
        
        private float _timer;
        private float _previousSecond;
        
        public float Timer => _timer;

        private void OnEnable()
        {
            onTimerEnd.AddListener(() =>
            {
                SceneManager.LoadScene("Paper");
            });
            
            onSecondPassed.AddListener(() =>
            {
                if (_timer <= 15.0f)
                {
                    Debug.Log("Timer Sound");
                    timerEvent.start();
                }
            });
        }

        private void Start()
        {
            _timer = minutes * 60 + seconds;
            musicEvent = FMODUnity.RuntimeManager.CreateInstance(music);
            musicEvent.start();
            
            timerEvent = FMODUnity.RuntimeManager.CreateInstance(timerSound);
        }

        private void Update()
        {
            if (!(_timer > 0)) return;
            if (Math.Abs(Mathf.Floor(_timer) - _previousSecond) > 0.1f)
            {
                onSecondPassed.Invoke();
                _previousSecond = Mathf.Floor(_timer);
            }
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                onTimerEnd.Invoke();
            }
        }

        private void OnDisable()
        {
            onTimerEnd.RemoveAllListeners();
            onSecondPassed.RemoveAllListeners();
            musicEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            //Debug.Log("Game Over");
        }
    }
}
