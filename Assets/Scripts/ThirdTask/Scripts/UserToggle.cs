using UnityEngine;
using UnityEngine.UI;

public abstract class UserToggle : MonoBehaviour
{
    protected Toggle toggle;
    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }
    public virtual void SetToggleStatement(bool isClicked)
    {
        toggle.isOn = isClicked;
    }
}
