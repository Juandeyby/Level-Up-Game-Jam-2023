using System.Collections;
using System.Collections.Generic;
using App.Scripts.Ocean;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurbinasGameManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject timerObj;
    //public GameObject selloApproved;

    private void Awake()
    {
        timerObj.SetActive(true);
        endGamePanel.SetActive(false);
        TurbinasStateGameCont.TurbinasWin = false;
    }
    /*private void Start()
    {
        StartCoroutine(StartGame());
    }*/

    private void Update()
    {
        if(TurbinasStateGameCont.energiaAdquirida == 18)
        {
            StartCoroutine(AppearObjectsInWin());
        }
    }

    public void LoseScreenTurbinas()
    {
        StartCoroutine(AppearObjectsInLose());
    }

    IEnumerator AppearObjectsInWin()
    {
        timerObj.SetActive(false);
        yield return new WaitForSeconds(3f);
        PA_GamePlay.Instance.ApproveMiniGame(1);
    }

    IEnumerator AppearObjectsInLose()
    {
        yield return new WaitForSeconds(1f);
        endGamePanel.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }

    /*IEnumerator StartGame()
    {
        
        yield return new WaitForSeconds(2f);
        
    }*/



    
}
