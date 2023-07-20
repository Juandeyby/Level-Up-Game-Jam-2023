using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PA_GamePlay : MonoBehaviour
{
    public static PA_GamePlay Instance;
    public PA_DataGame paDataGame;
    public PAUI_Start pauiStart;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        pauiStart = GetComponentInChildren<PAUI_Start>();
        paDataGame = GetComponentInChildren<PA_DataGame>();
    }
    
    public void LoadScene(string sceneName)
    {
        pauiStart.StartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(sceneName);
    }
}