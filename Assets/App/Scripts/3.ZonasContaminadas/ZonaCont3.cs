using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont3 : MonoBehaviour
{
    public BarraDeEnergia barraDeEnergia;
    public SpawnTreesFinal spawnTreesFinal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnerArboles.SpawnObjects();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnerArboles.SpawnObjects();
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida += 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.SpawnTreesMethod();
            spawnTreesFinal.NubesSucias1Method(3, TurbinasStateGameCont.nubeMala4 -= 0.5f);
            spawnTreesFinal.NubesLimpias1Method(3, TurbinasStateGameCont.nubeBuena4 += 0.5f);
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnerArboles.SpawnObjects();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnerArboles.DestroyTrees();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnerArboles.DestroyTrees();
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.DeSpawnTreesMethod();
            spawnTreesFinal.NubesSucias1Method(3, TurbinasStateGameCont.nubeMala4 += 0.5f);
            spawnTreesFinal.NubesLimpias1Method(3, TurbinasStateGameCont.nubeBuena4 -= 0.5f);
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnerArboles.DestroyTrees();
        }
    }
}
