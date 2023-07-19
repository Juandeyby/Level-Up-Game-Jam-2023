using System.Collections.Generic;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class PG_Ocean : MonoBehaviour
    {
        [SerializeField] List<PG_Wave> waves;
        
        public void EnableRandomWave(PG_Wave wave)
        {
            wave.gameObject.SetActive(false);
            var random = Random.Range(0, waves.Count);
            waves[random].gameObject.SetActive(true);
        }
    }
}
