using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class NewMonoBehaviourScript : MonoBehaviour
{

    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
