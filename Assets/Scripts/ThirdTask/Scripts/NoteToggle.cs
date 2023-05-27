using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class NoteToggle : UserToggle
{
    [SerializeField] GameObject notedGameObj;
    [SerializeField] Slider transparencySlider;
    private Material material;
    private void Start()
    {
        toggle = GetComponent<Toggle>(); 
        material = notedGameObj.GetComponent<Renderer>().material;
        
    }
    public void OnNotedToggleClick(bool isClicked)
    {
        if(isClicked)
        {
            transparencySlider.onValueChanged.AddListener(ChangeTransparency);
        }
        else
        {
            transparencySlider.onValueChanged.RemoveListener(ChangeTransparency);
        }

    }

    private void ChangeTransparency(float value)
    {
        Color oldColor = material.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, transparencySlider.value);
        material.SetColor("_Color", newColor);
    }

}
