using UnityEngine;
using UnityEngine.UI;

public abstract class UserToggle : MonoBehaviour
{
    protected Toggle toggle;
    public bool userTogl
    {
        get => toggle.isOn;
    }
    
    public virtual void SetToggleStatement(bool isClicked)
    {
        toggle.isOn = isClicked;
    }
}
