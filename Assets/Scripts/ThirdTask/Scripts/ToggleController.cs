using UnityEngine;


public class ToggleController : MonoBehaviour
{
    private NoteToggle[] noteToggles;
    private VisibilityToggle[] visibilityToggles;

    void Start()
    {
        noteToggles = GetComponentsInChildren<NoteToggle>();
        visibilityToggles = GetComponentsInChildren<VisibilityToggle>();
    }

    public void OnNoteHeaderToggleClick(bool isClicked)
    {
        ChangeTogglesStatement(isClicked, noteToggles);
    }
    public void OnVisibilityHeaderToggleClick(bool isClicked)
    {
        ChangeTogglesStatement(isClicked, visibilityToggles);

    }

    private void ChangeTogglesStatement(bool isClicked, UserToggle[] togglesArray)
    {
        if (isClicked)
        {
            foreach (var item in togglesArray)
            {
                item.SetToggleStatement( true);
            }
        }
        else
        {
            foreach (var item in togglesArray)
            {
                item.SetToggleStatement(false);
            }
        }
    }

}
