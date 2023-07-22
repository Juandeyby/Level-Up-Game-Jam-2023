using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaCont1 : MonoBehaviour
{

    public BarraDeEnergia barraDeEnergia;
    public SpawnerArboles spawnerArboles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida += 1f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.SpawnObjects();
            //FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Park_Level/Sticker Built");
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida += 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.SpawnObjects();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TurbType1"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 1f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.DestroyTrees();
        }
        if (collision.CompareTag("TurbType2"))
        {
            TurbinasStateGameCont.energiaAdquirida -= 0.5f;
            barraDeEnergia.SetEnergy(TurbinasStateGameCont.energiaAdquirida);
            spawnerArboles.DestroyTrees();
        }
    }
}
