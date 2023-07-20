using UnityEngine;
using UnityEngine.UI;

namespace App.Scripts.Paper
{
    public class PAUI_Start : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        
        public Button StartButton => startButton;
    }
}
