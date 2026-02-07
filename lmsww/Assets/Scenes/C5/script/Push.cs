using UnityEngine;

public class Push : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * 200);
        }
    }
}
