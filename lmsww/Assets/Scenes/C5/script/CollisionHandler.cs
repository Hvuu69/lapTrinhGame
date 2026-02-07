using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision: " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger: " + col.gameObject.name);
    }

}
