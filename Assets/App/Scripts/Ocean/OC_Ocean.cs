using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace App.Scripts.Ocean
{
    public class OC_Ocean : MonoBehaviour
    {
        [SerializeField] private List<OC_Wave> waves;
        [SerializeField] private int stickersSpawned = 0;
        public int StickersSpawned
        {
            get => stickersSpawned;
            set => stickersSpawned = value;
        }

        public void EnableRandomWave(OC_Wave wave)
        {
            wave.gameObject.SetActive(false);
            var random = Random.Range(0, waves.Count);
            SetTransform();
            waves[random].gameObject.SetActive(true);
            
        }
        
        public void SetTransform()
        {
            var newPosX = Random.Range(-10, 10);
            var t = transform;
            var position = t.localPosition;
            t.localPosition = new Vector3(newPosX, position.y, position.z);
        }
    }
}
