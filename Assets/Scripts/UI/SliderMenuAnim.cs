using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SliderMenuAnim : MonoBehaviour
{
    [SerializeField] GameObject MenuPanel;
    private Animator animator;
    private bool isOpened;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void ShowHideSlideMenu()
    {
        isOpened = animator.GetBool("Show");
        animator.SetBool("Show", !isOpened);
    }
}
