using UnityEngine;

public class PlayerHealth1 : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10); // Subtract 10 health points when H is pressed
        }
    }
}
