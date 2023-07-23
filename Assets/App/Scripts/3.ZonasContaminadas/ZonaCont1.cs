using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont1 : MonoBehaviour
{

    public BarraDeEnergia barraDeEnergia;
    public SpawnTreesFinal spawnTreesFinal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida += 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.SpawnTreesMethod();
            spawnTreesFinal.NubesSucias1Method(0, TurbinasStateGameCont.nubeMala1 -= 0.5f);
            spawnTreesFinal.NubesLimpias1Method(0, TurbinasStateGameCont.nubeBuena1 += 0.5f);
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesFinal.SpawnTreesMethod();
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesFinal.SpawnTreesMethod();
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesFinal.SpawnTreesMethod();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            
            TurbinasStateGameCont.energiaAdquirida -= 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesFinal.DeSpawnTreesMethod();
            spawnTreesFinal.NubesSucias1Method(0, TurbinasStateGameCont.nubeMala1 += 0.5f);
            spawnTreesFinal.NubesLimpias1Method(0, TurbinasStateGameCont.nubeBuena1 += 0.5f);
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesFinal.DeSpawnTreesMethod();
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesFinal.DeSpawnTreesMethod();
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            //spawnTreesFinal.DeSpawnTreesMethod();
        }
    }
}
