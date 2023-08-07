using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaContGeneral : MonoBehaviour
{

    [SerializeField] private string tagFromZone;
    [SerializeField] private bool hasClouds;
    [SerializeField] private int cloudeId;
    public SpawnTreesFinal spawnTreesFinal;

    private int numberThatEnter = 0;

    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (!collision.CompareTag(tagFromZone))
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
        else
        {
            if (numberThatEnter != 0)
                numberThatEnter++;
            else
            {
                AppropiatedTagEnter();
                numberThatEnter++;
            }  
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag(tagFromZone))
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
        else
        {
            if(numberThatEnter == 1)
            {
                AppropiatedTagExit();
                numberThatEnter--;
            }
            else
                numberThatEnter--;
        }
    }
    public void AppropiatedTagEnter()
    {
        TurbinasStateGameCont.energiaAdquirida += 2f;
        spawnTreesFinal.SpawnTreesMethod();
        if (hasClouds)
        {
            spawnTreesFinal.NubesSucias1Method(cloudeId, 0);
            spawnTreesFinal.NubesLimpias1Method(cloudeId, 1);
        }
        anim.SetBool("OutZone", true);
        spawnTreesFinal.SmogFilterMinusAlpha();
    }

    public void AppropiatedTagExit()
    {
        TurbinasStateGameCont.energiaAdquirida -= 2f;
        spawnTreesFinal.DeSpawnTreesMethod();
        if (hasClouds)
        {
            spawnTreesFinal.NubesSucias1Method(cloudeId, 1);
            spawnTreesFinal.NubesLimpias1Method(cloudeId, 0);
        }
        anim.SetBool("OutZone", false);
        spawnTreesFinal.SmogFilterPlusAlpha();
    }



    public void NoTagAppropiatedEnter()
    {
        TurbinasStateGameCont.energiaAdquirida += 0.5f;
    }

    public void NoTagAppropiatedExit()
    {
        TurbinasStateGameCont.energiaAdquirida -= 0.5f;
    }
}
