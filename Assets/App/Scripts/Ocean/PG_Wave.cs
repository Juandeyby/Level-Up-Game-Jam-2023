using System.Collections;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class PG_Wave : MonoBehaviour
    {
        [SerializeField] private PG_Ocean ocean;
        public void GetWave()
        {
            ocean.EnableRandomWave(this);
        }
    }
}
