using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class SliderMenuAnim : MonoBehaviour
{
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

    public void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}
