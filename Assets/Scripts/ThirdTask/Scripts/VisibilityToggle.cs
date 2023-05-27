using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class VisibilityToggle : UserToggle
{
    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }
}
