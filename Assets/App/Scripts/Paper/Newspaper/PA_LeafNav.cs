using System.Collections;
using System.Collections.Generic;
using App.Scripts.Paper.Newspaper;
using Unity.VisualScripting;
using UnityEngine;

public class PA_LeafNav : MonoBehaviour
{
    [SerializeField] private SpriteRenderer nav;
    [SerializeField] private PA_Leaf leaf;
    private bool _isLeft = true;
    
    void OnMouseDown(){

        if (_isLeft)
        {
            Debug.Log("Left");
            leaf.Newspaper.OnLeft();
            _isLeft = false;
        }
        else
        {
            Debug.Log("Right");
            leaf.Newspaper.OnRight();
            _isLeft = true;
        }
        //FMODUnity.RuntimeManager.PlayOneShot("event:/Newspaper/Pages");
        //Debug.Log("Page changed");
    }
    
    void OnMouseEnter(){
        nav.color = new Color32(0, 0, 0, 120);
    }
    
    void OnMouseExit(){
        nav.color = new Color32(0, 0, 0, 50);
    }
}