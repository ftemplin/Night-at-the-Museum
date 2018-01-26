using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {
    public VideoPlayer videoPlayer;
    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            videoPlayer.Stop();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            videoPlayer.Play();
        }
    }
}
