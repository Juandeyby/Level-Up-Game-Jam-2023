using System;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Trash : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Sticker"))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Beach_Level/Oil Collected");
                Destroy(col.gameObject);
                if (OC_GamePlay.Instance.Ocean.StickersSpawned <= 0)
                {
                    OC_GamePlay.Instance.ReturnToPaper();
                }
            }
        }
    }
}