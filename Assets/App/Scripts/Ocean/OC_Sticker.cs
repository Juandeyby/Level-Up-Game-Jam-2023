using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Sticker : MonoBehaviour
    {
        private void Start()
        {
            var ocOcean = OC_GamePlay.Instance.Ocean;
            Debug.Log(ocOcean.StickersSpawned, this);
            Debug.Log(transform.parent.name, this);
            ocOcean.StickersSpawned -= 1;
        }
    }
}
