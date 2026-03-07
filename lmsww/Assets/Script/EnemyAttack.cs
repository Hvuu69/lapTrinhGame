using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>(); // Check if the collider belongs to the player
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage); // Deal damage to the player
        }
    }
}