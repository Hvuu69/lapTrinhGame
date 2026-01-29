using UnityEngine;

public class TurretRotation2D : MonoBehaviour
{

    public bool aimWithMouse = false;

    [Header("Target ")]
    public Transform target;

    [Header("Rotation Settings")]
    public bool smoothRotation = true;
    public float rotateSpeed = 180f; // độ / giây

    void Update()
    {
        Vector2 direction;

        if (aimWithMouse)
        {
            Vector3 mouseWorld =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorld.z = 0;

            direction = mouseWorld - transform.position;
        }
        else
        {
            if (target == null) return;
            direction = target.position - transform.position;
        }

        if (direction.sqrMagnitude < 0.001f) return;

        // Sprite mặc định hướng lên
        float angle = Vector2.SignedAngle(Vector2.up, direction);
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);

        if (smoothRotation)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotateSpeed * Time.deltaTime
            );
        }
        else
        {
            transform.rotation = targetRotation;
        }
    }
}
