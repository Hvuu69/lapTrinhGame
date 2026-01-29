using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
            Debug.Log(isMuted ? "Muted all audio" : "Unmuted all audio");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            if (isPaused)
                AudioListener.pause = true;
            else
                AudioListener.pause = false;
            Debug.Log(isPaused ? "Paused all audio" : "Resumed all audio");
        }
    }
}
