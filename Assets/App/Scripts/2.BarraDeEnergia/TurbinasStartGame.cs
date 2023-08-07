using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurbinasStartGame : MonoBehaviour
{
    private TMP_Text levelText;

    void Start()
    {
        levelText = GameObject.Find("LevelText").GetComponent<TMP_Text>();
        levelText.text = "Level: " + TurbinasStateGameCont.currentLevel;
    }


    void Update()
    {
        
    }
}
