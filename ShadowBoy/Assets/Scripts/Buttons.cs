using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Buttons : MonoBehaviour 
{
    public Light2D [] lights;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleLights);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleLights();
        }
    }

    void ToggleLights()
    {
        foreach (Light2D light in lights)
        {
            light.enabled = !light.enabled;
        }
    }
}
