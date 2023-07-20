using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper.Newspaper;
using UnityEngine;

public class PA_Page : MonoBehaviour
{
    [SerializeField] private PA_Leaf leaf;
    [SerializeField] private SpriteRenderer page;
    
    public void SetPage()
    {
        var current = page.flipX;
        page.flipX = !current;
        page.sprite = leaf.Newspaper.GetPage();
    }
}