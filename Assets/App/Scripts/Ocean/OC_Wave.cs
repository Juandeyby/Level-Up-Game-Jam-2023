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
            //FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Beach_Level/WavesMovement");
        }

        public void PlaySound()
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Beach_Level/WavesMovement");
        }
    }

}
