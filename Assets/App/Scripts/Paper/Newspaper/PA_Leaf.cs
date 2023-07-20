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
    }
}
