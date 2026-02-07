using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Bullet hit: {collision.name}, Damage: {damage}");
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }
}