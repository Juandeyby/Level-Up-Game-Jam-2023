using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbinasGameManager : MonoBehaviour
{
    public GameObject textWin, textLose;
    public GameObject backBttn, endGamePanel;

    private void Awake()
    {
        endGamePanel.SetActive(false);
        textWin.SetActive(false);
        textLose.SetActive(false);
        backBttn.SetActive(false);
        TurbinasStateGameCont.TurbinasWin = false;
    }

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
        endGamePanel.SetActive(true);
        textWin.SetActive(true);
        yield return new WaitForSeconds(2f);
        backBttn.SetActive(true);
    }

    IEnumerator AppearObjectsInLose()
    {
        endGamePanel.SetActive(true);
        textLose.SetActive(true);
        yield return new WaitForSeconds(2f);
        backBttn.SetActive(true);
    }

    
}
