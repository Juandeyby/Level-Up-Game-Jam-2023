using System.Collections.Generic;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Ocean : MonoBehaviour
    {
        [SerializeField] List<OC_Wave> waves;
        
        public void EnableRandomWave(OC_Wave wave)
        {
            wave.gameObject.SetActive(false);
            var random = Random.Range(0, waves.Count);
            waves[random].gameObject.SetActive(true);
        }
    }
}
