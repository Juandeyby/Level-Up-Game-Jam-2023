using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper;
using App.Scripts.Paper.Newspaper;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PA_GamePlay : MonoBehaviour
{
    public static PA_GamePlay Instance;
    
    [SerializeField] private Transform originCamera;
    [SerializeField] private Animator[] approvedAnimators;
    public PA_DataGame paDataGame;
    public PAUI_Start pauiStart;
    
    private Transform _lastTransform;
    public Transform LastTransform
    {
        get => _lastTransform;
        set => _lastTransform = value;
    }
    [SerializeField] private List<PA_MiniGame> paMiniGames;
    public List<PA_MiniGame> PaMiniGames
    {
        get => paMiniGames;
        set => paMiniGames = value;
    }
    
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
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Paper" && _lastTransform != null)
        {
            var paCamera = FindObjectOfType<PA_Camera>();
            paCamera.SetOrigin(_lastTransform);
            paCamera.SetTarget(originCamera, () =>
            {
                paMiniGames.ForEach(x => x.Show());
            });
        }
    }

    public void ApproveMiniGame(int index)
    {
        approvedAnimators[index].SetTrigger("Approved");
    }
}