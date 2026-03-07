using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;
    public System.Action onDead;

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
        onDead?.Invoke();
    }
    private void Start() => healthPoint = defaultHealthPoint;

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        Debug.Log($"TakeDamage called. Current health: {healthPoint}, Damage: {damage}");

        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }
}
