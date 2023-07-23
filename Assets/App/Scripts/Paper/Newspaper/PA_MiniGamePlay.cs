using Lean.Gui;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace App.Scripts.Paper.Newspaper
{
    public class PA_MiniGamePlay : MonoBehaviour
    {
        [SerializeField] private PA_MiniGame paMiniGame;
        [SerializeField] private Transform target;
        [SerializeField] private LeanButton button;
    
        private void Awake()
        {
            button.OnClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            var paGamePlay = PA_GamePlay.Instance;
            paGamePlay.LastTransform = target;
            paGamePlay.PaMiniGames.ForEach(x => x.Hide());
            
            var paCamera = FindObjectOfType<PA_Camera>();
            paCamera.SetTarget(target, StartMiniGame);
        }

        private void StartMiniGame()
        {
            var toScene = paMiniGame.MiniGameType.ToString();
            SceneManager.LoadScene(toScene);
        }
    }
}
