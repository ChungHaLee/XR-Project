using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    private GameObject canvas;
    
    public void Video()
    {
        VideoPlayer video = GetComponent<VideoPlayer>();
        video.playOnAwake = false;
        video.enabled = true;
        video.Prepare();
        video.Play();
        video.loopPointReached += EndReached;
        
    }

    void EndReached(VideoPlayer video)
    {
        canvas = GameObject.Find("Canvas");
        video.enabled = false;
        
        canvas.GetComponent<Canvas>().enabled = true;
    }
}
