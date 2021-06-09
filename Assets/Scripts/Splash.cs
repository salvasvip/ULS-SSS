using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Splash : MonoBehaviour
{
    public float waitTime = 7f;
    public VideoPlayer _videoPlayer = null; //your videoplayer component

    void Start()
    {
        StartCoroutine(WaitForIntro());
        _videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,"intro1.mp4");
    }

    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(2);
    }
}
