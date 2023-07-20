using System.Collections;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Wave : MonoBehaviour
    {
        [SerializeField] private OC_Ocean ocean;
        public void GetWave()
        {
            ocean.EnableRandomWave(this);
        }
    }
}
