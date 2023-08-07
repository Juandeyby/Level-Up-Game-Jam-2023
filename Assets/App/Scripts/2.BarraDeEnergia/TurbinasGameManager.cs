using System.Collections;
using System.Collections.Generic;
using App.Scripts.Ocean;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TurbinasGameManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject timerObj;
    public GameObject retryButton, continueButton, backButton;
    public GameObject energiasLimpiasParent;
    public GameObject selloAprobado;
    [HideInInspector] public bool allReadyWin = false;
    
    //public GameObject levelTextObj;
    //public GameObject selloApproved;

    private void Awake()
    {
        timerObj.SetActive(true);
        endGamePanel.SetActive(false);
        TurbinasStateGameCont.TurbinasWin = false;
        TurbinasStateGameCont.energiaAdquirida = 0f;
        //TurbinasStateGameCont.moreSpeed = 1f;
    }

    private void Update()
    {
        if(TurbinasStateGameCont.energiaAdquirida >= 18f)
        {
            WinScreenTurbinas();
        }
        //Debug.Log(TurbinasStateGameCont.energiaAdquirida);
    }

    public void LoseScreenTurbinas()
    {
        backButton.SetActive(true);
        retryButton.SetActive(true);
        energiasLimpiasParent.SetActive(false);
        //StartCoroutine(AppearObjectsInLose());
    }

    public void WinScreenTurbinas()
    {
        selloAprobado.SetActive(true);
        allReadyWin = true;
        StartCoroutine(AppearObjectsInWin());
    }

    IEnumerator AppearObjectsInWin()
    {
        yield return new WaitForSeconds(2.5f);
        backButton.SetActive(true);
        continueButton.SetActive(true);
    }

    IEnumerator AppearObjectsInLose()
    {
        yield return new WaitForSeconds(1f);
        endGamePanel.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);

    }

    public void RetryBttn()
    {
        SceneManager.LoadScene(3);
    }

    public void BackBttn()
    {
        TurbinasStateGameCont.moreSpeed = 1f;
        TurbinasStateGameCont.currentLevel = 1;
        PA_GamePlay.Instance.ApproveMiniGame(1);
    }

    public void ContinueBttn()
    {
        TurbinasStateGameCont.currentLevel += 1;
        TurbinasStateGameCont.moreSpeed += 1.2f;
        SceneManager.LoadScene(3);
    }


}
