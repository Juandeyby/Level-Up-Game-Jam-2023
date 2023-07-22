using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont2 : MonoBehaviour
{
    public BarraDeEnergia barraDeEnergia;
    public SpawnerArboles spawnerArboles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida += 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.SpawnObjects();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida += 1f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.SpawnObjects();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 2f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.DestroyTrees();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 1f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.DestroyTrees();
        }
    }
}
