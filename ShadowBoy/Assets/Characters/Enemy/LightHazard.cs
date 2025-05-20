using UnityEngine;

public class LightHazard : MonoBehaviour
{
    private int damagePerSecond = 5;
    private float damageInterval = 0.5f; // Cada cuánto aplica daño
    private float nextDamageTime;
    private bool playerInTrigger = false;
    private HealthSystem currentHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            currentHealth = other.GetComponent<HealthSystem>();
            playerInTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = false;
        }
    }
    
    void Update()
    {
        if (playerInTrigger && Time.time >= nextDamageTime && currentHealth != null)
        {
            currentHealth.TakeDamage(damagePerSecond);
            nextDamageTime = Time.time + damageInterval;
        }
    }
}
