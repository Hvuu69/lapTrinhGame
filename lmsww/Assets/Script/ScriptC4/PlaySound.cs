using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            Debug.Log("Play sound");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
            Debug.Log("Stop sound");
        }
    }
}
