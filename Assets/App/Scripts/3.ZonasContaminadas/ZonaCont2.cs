using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont2 : MonoBehaviour
{
    public BarraDeEnergia barraDeEnergia;
    public SpawnTreesFinal spawnTreesFinal;
    public bool idZone2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesBetter.SpawnObjects();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida += 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.SpawnTreesMethod();

            if (idZone2)
            {
                spawnTreesFinal.NubesSucias1Method(2, 0);
                spawnTreesFinal.NubesLimpias1Method(2, 1);
            }

            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesBetter.SpawnObjects();
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesBetter.SpawnObjects();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesBetter.DestroyTrees();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.DeSpawnTreesMethod();

            if (idZone2)
            {
                spawnTreesFinal.NubesSucias1Method(2, 1);
                spawnTreesFinal.NubesLimpias1Method(2, 0);
            }

            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesBetter.DestroyTrees();
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesBetter.DestroyTrees();
        }
    }
}
