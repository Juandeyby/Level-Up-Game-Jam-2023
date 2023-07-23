using System.Collections.Generic;
using Lean.Gui;
using UnityEngine;

namespace App.Scripts.Paper.Newspaper
{
    public class PA_Leaf : MonoBehaviour
    {
        [SerializeField] private PA_Newspaper newspaper;
        [SerializeField] private Animator animator;
        [SerializeField] private PA_Page page;
        private static readonly int Left = Animator.StringToHash("Left");
        private static readonly int Right = Animator.StringToHash("Right");
        public bool isLeft = true;

        public PA_Newspaper Newspaper => newspaper;

        public void OnLeft()
        {
            animator.SetTrigger(Left);
        }
        
        public void OnRight()
        {
            animator.SetTrigger(Right);
        }
        
        public void SetPage()
        {
            page.SetPage();
        }

        void PlayPagesEvent(string path)
        {
            FMOD.Studio.EventInstance Pages = FMODUnity.RuntimeManager.CreateInstance(path);
            Pages.start();
            Pages.release();
        }
       
        public void ShowMiniGame()
        {
            var paMiniGames = PA_GamePlay.Instance.PaMiniGames;
            paMiniGames.ForEach(x => x.Show());
        }
        
        public void HideMiniGame()
        {
            var paMiniGames = PA_GamePlay.Instance.PaMiniGames;
            paMiniGames.ForEach(x => x.Hide());
        }
    }
}
