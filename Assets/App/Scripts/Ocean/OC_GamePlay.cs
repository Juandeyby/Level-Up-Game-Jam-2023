using UnityEngine;
using UnityEngine.SceneManagement;

namespace App.Scripts.Ocean
{
    public class OC_GamePlay : MonoBehaviour
    {
        public static OC_GamePlay Instance;
        public OC_Ocean Ocean;
        public OC_Status Status;
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        
        public void ReturnToPaper()
        {
            SceneManager.LoadScene("Paper");
        }
    }
}
