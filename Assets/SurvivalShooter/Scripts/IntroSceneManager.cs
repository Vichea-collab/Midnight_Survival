using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntroSceneManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    private Coroutine transitionRoutine;

    private void Start()
    {
        videoPlayer.loopPointReached += VideoPlayer_loopPointReached;
    }

    private void VideoPlayer_loopPointReached(VideoPlayer source)
    {
        if (transitionRoutine == null)
        {
            transitionRoutine = StartCoroutine(LoadNextSceneWithDelay());
        }
    }

    private IEnumerator LoadNextSceneWithDelay()
    {
        yield return new WaitForSeconds(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}   
