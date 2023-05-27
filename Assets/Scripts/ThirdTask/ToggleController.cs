using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    [SerializeField] Toggle [] toggles;
    public void OnMainToggleClick(bool isClicked)
    {
        if(isClicked)
        {
            foreach (Toggle item in toggles)
            {
                item.isOn = true;
            }
        }
        else
        {
            foreach (Toggle item in toggles)
            {
                item.isOn = false;
            }
        }
    }

}
