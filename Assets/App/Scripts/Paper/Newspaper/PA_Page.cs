using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper.Newspaper;
using UnityEngine;

public class PA_Page : MonoBehaviour
{
    [SerializeField] private PA_Leaf leaf;
    [SerializeField] private SpriteRenderer page;
    [SerializeField] private List<GameObject> children;

    public void SetPage()
    {
        var current = page.flipX;
        page.flipX = !current;
        page.sprite = leaf.Newspaper.GetPage();
        
        if (page.flipX)
        {
            EnableChildren();
        }
        else
        {
            DisableChildren();
        }
    }

    private void EnableChildren()
    {
        foreach (var child in children)
        {
            child.SetActive(true);
        }
    }
    
    private void DisableChildren()
    {
        foreach (var child in children)
        {
            child.SetActive(false);
        }
    }
}