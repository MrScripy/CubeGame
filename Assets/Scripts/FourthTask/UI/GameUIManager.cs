using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameObject winPanel;
    void Start()
    {
        winPanel.SetActive(false);
    }

    public void OnMainMenuButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
