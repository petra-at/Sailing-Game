using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AnimatedVideo : MonoBehaviour
{
    private GameObject videocamera, video;
    private VideoPlayer clip;
    private AudioSource sound;

    public void PlayVideo()
    {
        //find VideoCamera Object and SetActive
       
        video =GameObject.Find("VideoPlayer");

        clip = video.GetComponent<VideoPlayer>();
        clip.enabled = true; 
        sound = video.GetComponent<AudioSource>();

        sound.Play();
        clip.Play();

        var close = GameObject.Find("Canvas/closeButton");
        var image = close.GetComponent<Image>();
        image.enabled = true; 

    }

    public void CloseVideo()
    {
        video = GameObject.Find("VideoPlayer");
        sound = video.GetComponent<AudioSource>();
        clip = video.GetComponent<VideoPlayer>();
        clip.enabled = false;
        sound.Stop(); 

        var close = GameObject.Find("Canvas/closeButton");
        var image = close.GetComponent<Image>();
        image.enabled = false; 
    }
}
