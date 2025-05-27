using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LazerDamage : MonoBehaviour
{
    public GameObject lazer;
    public bool lightOn = true;
    public float damagePerSecond = 25f;

    void Update()
    {
         lazer.SetActive(lightOn);
    }
    public bool IsActive()
    {
        return lightOn && lazer.activeInHierarchy;
    }
}   



