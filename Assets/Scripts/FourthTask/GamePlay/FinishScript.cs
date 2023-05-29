using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField] GameObject winPanel;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
