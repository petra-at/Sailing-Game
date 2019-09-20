using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Video;
using UnityEngine.UI; 

public class PlayVid : MonoBehaviour
{

    private GameObject videocamera, video;
    private VideoPlayer clip;
    private AudioSource sound;

    public void PlayVideo()
    {
        //find VideoCamera Object and SetActive 
        videocamera = GameObject.Find("Camera/VideoCamera");
        videocamera.GetComponent<Camera>().enabled = true;

        video = GameObject.Find("Camera/vid");
        clip = video.GetComponent<VideoPlayer>();
        sound = video.GetComponent<AudioSource>();

        sound.Play();
        clip.Play(); 

        //var close = GameObject.Find("Canvas/closeButton");
        //var image = close.GetComponent<Image>();
        //image.enabled = true; 
     
    }

    public void CloseVideo()
    {
        video = GameObject.Find("VideoPlayer");
        sound = video.GetComponent<AudioSource>();
        clip = video.GetComponent<VideoPlayer>();
        clip.enabled = false;
        sound.Stop();

        //var close = GameObject.Find("Canvas/closeButton");
       // var image = close.GetComponent<Image>();
        //image.enabled = false; 
    }
}
