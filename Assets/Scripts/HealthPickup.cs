using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                health.Heal(20); // Heal the player by 20 HP
                Destroy(gameObject); // Destroy the pickup after use
            }
        }
    }
}
