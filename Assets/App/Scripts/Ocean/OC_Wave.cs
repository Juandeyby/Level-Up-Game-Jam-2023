using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Wave : MonoBehaviour
    {
        
        [SerializeField] private OC_Ocean ocean;
        [SerializeField] private List<OC_Sticker> stickersPrefabs;
        [SerializeField] private List<Transform> stickerSlots;
        [SerializeField] private Transform stickersParent;
        
        public void GetWave()
        {
            ocean.EnableRandomWave(this);
            //FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Beach_Level/WavesMovement");
        }

        public void PlaySound()
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Beach_Level/WavesMovement");
        }
        
        public void SpawnSticker()
        {
            var ocOcean = OC_GamePlay.Instance.Ocean;
            if (ocOcean.StickersSpawned <= 0) return;
            var randomPrefab = Random.Range(0, stickersPrefabs.Count);
            var randomSlot = Random.Range(0, stickerSlots.Count);
            for (var i = 0; i < 6; i++)
            {
                Spawn(randomPrefab++, randomSlot++);
            }
        }

        public void Spawn(int randomPrefab, int randomSlot)
        {
            Instantiate(stickersPrefabs[randomPrefab % stickersPrefabs.Count], stickerSlots[randomSlot % stickerSlots.Count].position, Quaternion.identity, stickersParent);
        }
    }
}
