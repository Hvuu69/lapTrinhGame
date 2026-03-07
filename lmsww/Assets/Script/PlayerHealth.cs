using UnityEngine;

public class PHealth : Health
{
    public event System.Action onDead; // Added onDead event

    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
        onDead?.Invoke(); // Invoke the event
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10); // Subtract 10 health points when H is pressed
        }
    }
}
