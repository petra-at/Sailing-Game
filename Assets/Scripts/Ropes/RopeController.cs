using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RopeController : MonoBehaviour {

    Animator anim;
    GameObject text1,text2,title,button,f8button;
    Plane plane;
    AudioSource audioS; 

	// Use this for initialization
	
    void Start () 
    {
        anim = GetComponent<Animator>(); 

	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void ButtonPressed()
    {
        text1 = GameObject.Find("Canvas/Intro_Description1");
        text1.SetActive(false);// hide the first active

        text2 = GameObject.Find("Canvas/Intro_Description2");
        text2.SetActive(false);// hide the second active

        title = GameObject.Find("Canvas/TitlePanel/TitleText1");
        title.SetActive(false);//hide the active 

        title = GameObject.Find("Canvas/TitlePanel/TitleText2");
        title.SetActive(true);//set fo8 title active 

        text1 = GameObject.Find("Canvas/TitlePanel/Fo8_Description");
        text1.SetActive(true); //set figure of eight description active
       
        button = GameObject.Find("Canvas/Button");
        button.SetActive(false);//hide the let's begin button 

        f8button = GameObject.Find("Canvas/TitlePanel/Figure8KnotButton");
        f8button.SetActive(true);

        var plane = GameObject.Find("PlaneStorage/Plane"); 
        plane.GetComponent<MeshRenderer>().enabled =true;

        var playbutton = GameObject.Find("Canvas/work/PlayButton");
        playbutton.SetActive(true);


    }

    public void ReturnHome()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Topics"); 
    }
}
