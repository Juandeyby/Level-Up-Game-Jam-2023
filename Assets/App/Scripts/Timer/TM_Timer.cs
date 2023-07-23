using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace App.Scripts.Timer
{
    public class TM_Timer : MonoBehaviour
    {
        [SerializeField] private int minutes = 1;
        [SerializeField] private int seconds = 30;
        public UnityEvent onTimerEnd;
        public UnityEvent onSecondPassed;

        public string music = "event:/Music/Music";
        FMOD.Studio.EventInstance musicEvent;

        private float _timer;
        private float _previousSecond;
        
        public float Timer => _timer;

        private void OnEnable()
        {
            onTimerEnd.AddListener(() =>
            {
                Debug.Log("Timer End");
            });
        }

        private void Start()
        {
            _timer = minutes * 60 + seconds;
            musicEvent = FMODUnity.RuntimeManager.CreateInstance(music);
            musicEvent.start();
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
