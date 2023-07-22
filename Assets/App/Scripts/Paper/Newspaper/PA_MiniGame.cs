using UnityEngine;

namespace App.Scripts.Paper.Newspaper
{
    public class PA_MiniGame : MonoBehaviour
    {
        [SerializeField] private MiniGameType miniGameType;
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private PA_MiniGamePlay miniGamePlay;
        [SerializeField] private Transform target;
        
        public PA_MiniGamePlay MiniGamePlay => miniGamePlay;
        public MiniGameType MiniGameType => miniGameType;
        public Transform Target => target;
        
        public void Show()
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
        
        public void Hide()
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
    }
    
    public enum MiniGameType
    {
        None,
        Ocean,
        Factory,
    }
}
