using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{

    public VideoPlayer video;

    void Start()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
        video.loopPointReached += EndReached;
    }

    IEnumerator playVideo()
    {

        //Disable Play on Awake for both Video and Audio
        video.playOnAwake = false;

        video.Prepare();
        //Wait until video is prepared
        WaitForSeconds waitTime = new WaitForSeconds(1);
        while (!video.isPrepared)
        {
            Debug.Log("Preparing Video");
            //Prepare/Wait for 5 sceonds only
            yield return waitTime;
            //Break out of the while loop after 5 seconds wait
            break;
        }
        Debug.Log("Done Preparing Video");

        //Play Video
        video.Play();
        //Play Sound
        Debug.Log("Playing Video");
        while (video.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)video.time));
            yield return null;
        }
        Debug.Log("Done Playing Video");
    }

    // Update is called once per frame
    void EndReached(VideoPlayer video)
    {
        SceneManager.LoadScene("Menu");
    }
}




