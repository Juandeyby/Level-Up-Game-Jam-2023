using System;
using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper.Newspaper;
using UnityEngine;

public class PA_Newspaper : MonoBehaviour
{
    [SerializeField] private List<Sprite> pages;
    [SerializeField] private List<PA_Leaf> leafs;
    private int _currentPage = 0;

    private void Awake()
    {
        
    }

    public void OnLeft()
    {
        var leaf = _currentPage / 2 % leafs.Count;
        leafs[leaf].OnLeft();
        _currentPage++;
    }
    
    public void OnRight()
    {
        var leaf = _currentPage / 2 % leafs.Count;
        leafs[leaf].OnRight();
        _currentPage--;
    }

    public Sprite GetPage()
    {
        //var leaf = _currentLeaf % leafs.Count;
        return pages[_currentPage];
    }
}
