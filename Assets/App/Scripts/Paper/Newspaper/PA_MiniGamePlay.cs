using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper;
using App.Scripts.Paper.Newspaper;
using Lean.Gui;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PA_MiniGamePlay : MonoBehaviour
{
    
    [SerializeField] private PA_MiniGame paMiniGame;
    [SerializeField] private Transform target;
    [SerializeField] private LeanButton button;
    
    private void Awake()
    {
        button.OnClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        paMiniGame.Hide();
        var paCamera = FindObjectOfType<PA_Camera>();
        paCamera.SetTarget(target, StartMiniGame);
    }

    private void StartMiniGame()
    {
        var toScene = paMiniGame.MiniGameType.ToString();
        SceneManager.LoadScene(toScene);
    }
}
