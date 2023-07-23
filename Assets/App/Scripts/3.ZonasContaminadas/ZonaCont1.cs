using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont1 : MonoBehaviour
{

    public BarraDeEnergia barraDeEnergia;
    public SpawnTreesFinal spawnTreesFinal;
    public int idZone1;
    private bool stayOnZone = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("TurbType1"))
        {
            NoTagAppropiatedEnter();
            /*TurbinasStateGameCont.energiaAdquirida += 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.SpawnTreesMethod();
            spawnTreesFinal.NubesSucias1Method(idZone1, 0);
            spawnTreesFinal.NubesLimpias1Method(idZone1, 1);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);*/
        }
        else
        {
                TurbinasStateGameCont.energiaAdquirida += 2f;
                barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
                spawnTreesFinal.SpawnTreesMethod();
                spawnTreesFinal.NubesSucias1Method(idZone1, 0);
                spawnTreesFinal.NubesLimpias1Method(idZone1, 1);
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            
        }
        
        /*
        if (collision.CompareTag("TurbType2"))
        {
            NoTagAppropiatedEnter();
        }
        if (collision.CompareTag("TurbType3"))
        {
            NoTagAppropiatedEnter();
        }
        if (collision.CompareTag("TurbType4"))
        {
            NoTagAppropiatedEnter();
        }*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("TurbType1"))
        {
            NoTagAppropiatedExit();
            /*TurbinasStateGameCont.energiaAdquirida -= 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.DeSpawnTreesMethod();
            spawnTreesFinal.NubesSucias1Method(idZone1, 1);
            spawnTreesFinal.NubesLimpias1Method(idZone1, 0);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);*/
        }
        else
        {
                TurbinasStateGameCont.energiaAdquirida -= 2f;
                barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
                spawnTreesFinal.DeSpawnTreesMethod();
                spawnTreesFinal.NubesSucias1Method(idZone1, 1);
                spawnTreesFinal.NubesLimpias1Method(idZone1, 0);
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            
        }

        /*
        if (collision.CompareTag("TurbType2"))
        {
            NoTagAppropiatedExit();
        }
        if (collision.CompareTag("TurbType3"))
        {
            NoTagAppropiatedExit();
        }
        if (collision.CompareTag("TurbType4"))
        {
            NoTagAppropiatedExit();
        }*/
    }

    public void NoTagAppropiatedEnter()
    {
        TurbinasStateGameCont.energiaAdquirida += 0.5f;
        barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
    }

    public void NoTagAppropiatedExit()
    {
        TurbinasStateGameCont.energiaAdquirida -= 0.5f;
        barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
    }
}
