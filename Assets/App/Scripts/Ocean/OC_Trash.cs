using System;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Trash : MonoBehaviour
    {
        [SerializeField] private int stickersDestroyed = 0;

        private void Awake()
        {
            stickersDestroyed = OC_GamePlay.Instance.Ocean.StickersSpawned;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Sticker"))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Beach_Level/Oil Collected");
                Destroy(col.gameObject);
                stickersDestroyed--;
                if (stickersDestroyed <= 0)
                {
                    OC_GamePlay.Instance.ReturnToPaper();
                }
            }
        }
    }
}