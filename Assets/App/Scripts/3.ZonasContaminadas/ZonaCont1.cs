using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont1 : MonoBehaviour
{

    public BarraDeEnergia barraDeEnergia;
    public SpawnTreesBetter spawnTreesBetter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            //if (TurbinasStateGameCont.canIntegrate)
            //{
                TurbinasStateGameCont.energiaAdquirida += 2f;
                barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.SpawnObjects();
            //}
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.SpawnObjects();
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.SpawnObjects();
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.SpawnObjects();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            
            TurbinasStateGameCont.energiaAdquirida -= 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.DestroyTrees();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.DestroyTrees();
        }
        if (collision.CompareTag("TurbType3"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.DestroyTrees();
        }
        if (collision.CompareTag("TurbType4"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnTreesBetter.DestroyTrees();
        }
    }
}
