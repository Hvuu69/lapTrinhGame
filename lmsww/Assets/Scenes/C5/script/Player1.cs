using UnityEngine;

public class Player1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision with: " + col.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger with: " + col.gameObject.name);
    }
}
