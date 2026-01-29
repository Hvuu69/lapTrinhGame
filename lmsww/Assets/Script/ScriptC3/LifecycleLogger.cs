using UnityEngine;

public class LifecycleDebugger : MonoBehaviour
{
    // Prefab để Instantiate
    public GameObject prefabToSpawn;

    void Awake()
    {
        Debug.Log($"{name} - Awake");
    }

    void OnEnable()
    {
        Debug.Log($"{name} - OnEnable");
    }

    void Start()
    {
        Debug.Log($"{name} - Start");
    }

    void Update()
    {
        Debug.Log($"{name} - Update");

        // I: Instantiate
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(prefabToSpawn);
            Debug.Log("Instantiate prefab");
        }

        // T: Toggle Active
        if (Input.GetKeyDown(KeyCode.T))
        {
            gameObject.SetActive(false);
        }

        // U: Destroy
        if (Input.GetKeyDown(KeyCode.U))
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        Debug.Log($"{name} - FixedUpdate");
    }

    void LateUpdate()
    {
        Debug.Log($"{name} - LateUpdate");
    }

    void OnDisable()
    {
        Debug.Log($"{name} - OnDisable");
    }

    void OnDestroy()
    {
        Debug.Log($"{name} - OnDestroy");
    }
}
