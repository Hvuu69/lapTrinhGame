using UnityEngine;
using UnityEngine.Video;

public class VideoEventControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI;

    void Start()
    {
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnPrepared(VideoPlayer vp)
    {
        vp.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        endUI.SetActive(true);
    }

}
