using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteroClock : MonoBehaviour
{
    [SerializeField] private TurbinasGameManager turbinasGameManager;
    private float tiempoTranscurrido = 0f;
    private float startMinutero = 0f;
    private float minutoReal = 0f;


    public string music = "event:/Music/Music";
    FMOD.Studio.EventInstance musicEvent;

    private void Start()
    {
        
        musicEvent = FMODUnity.RuntimeManager.CreateInstance(music);
        musicEvent.start();
    }

    void Update()
    {
        OnStart();
    }

    private void OnStart()
    {
        startMinutero += Time.deltaTime * 180f;
        if (startMinutero <= 360f)
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 180f);
        }
        else
        {
            StartCoroutine(StartGameTurbinas());
        }
    }

    private void CloackStart()
    {
        //Debug.Log(tiempoTranscurrido);
        if (!turbinasGameManager.allReadyWin)
        {
            tiempoTranscurrido += (Time.deltaTime * 6f * TurbinasStateGameCont.moreSpeed) / 60f;
            if (tiempoTranscurrido < 6f)
            {
                minutoReal = Time.deltaTime * 6f;
                transform.Rotate(Vector3.forward * minutoReal * TurbinasStateGameCont.moreSpeed);
            }
            else
            {
                turbinasGameManager.LoseScreenTurbinas();
            }
        }
        
    }

    IEnumerator StartGameTurbinas()
    {
        yield return new WaitForSeconds(1f);
        CloackStart();
    }

    private void OnDisable()
    {
        
        musicEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        
        //Debug.Log("Game Over");
    }
}
