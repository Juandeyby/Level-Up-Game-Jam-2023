using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper.Newspaper;
using Lean.Gui;
using Unity.VisualScripting;
using UnityEngine;

public class PA_LeafNavReturn : MonoBehaviour
{
    [SerializeField] private LeanButton button;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private PA_Leaf leaf;

    private void Awake()
    {
        button.OnClick.AddListener(OnClick);
    }

    void OnClick(){

        if (leaf.isLeft == false)
        {
            Debug.Log("Right");
            leaf.Newspaper.OnRight();
            leaf.isLeft = true;
            Hide();
        }
    }
    
    private void Show()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }
    
    private void Hide()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}