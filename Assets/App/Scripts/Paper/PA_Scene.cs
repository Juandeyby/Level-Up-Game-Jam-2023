using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PA_Scene : MonoBehaviour
{
    public static PA_Scene Instance;
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
    }
    
    public void LoadScene(string sceneName)
    {
        pauiStart.StartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(sceneName);
    }
}