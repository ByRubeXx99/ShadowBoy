using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [Header("Health System")]
    public int maxHealth = 100;
    public int currentHealth;

    [Header("Dead")]
    public bool isDead = false;

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Vida inicial del jugador: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (isDead) {  return; }

        currentHealth -= damage;

        Debug.Log("¡Daño recibido! -" + damage + ". Vida restante: " + currentHealth);

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);   // Hace que no baje de 0 ni suba de 100 de vida

        if (currentHealth <= 0 && !isDead)
        {
            Die();
        }
    }


    public void Die()
    {
        isDead = true;
        Debug.Log("¡El jugador ha muerto!"); // Mensaje al morir

    }

    public void ResetHealth()
    {
        isDead = false;
        currentHealth = maxHealth;

    }
}
