using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SailingIntroController : MonoBehaviour
{
    
    private GameObject yatch,dinghy,keelboat,sailboat;
    public Animation anim;
    public MeshRenderer meshrenderer; 

   
    public void IntroTextNext()
    {
        // hide introtext section
        var currentsection = GameObject.Find("Canvas/SidePanel/IntroText");
        currentsection.SetActive(false); 

        // show boat section
        var nextsection = GameObject.Find("Canvas/SidePanel/BoatsText");
        nextsection.SetActive(true);

        // hide the sail boat 
        HideSailBoatMesh();

        //play dinghy animation
        ShowDinghyMesh();
        PlayDinghyAnimation();

        //play yatch animation
        ShowYatchMesh();
        PlayYatchAnimation(); 

        //play keelboat animation
        ShowKeelboatMesh();
        PlayKeelboatAnimation();

      
    }

    public void BoatTextNext()
    {
        // hide boat section
        var currentsection = GameObject.Find("Canvas/SidePanel/BoatsText");
        currentsection.SetActive(false);
        // show next section
        var nextsection = GameObject.Find("Canvas/SidePanel/EssentialsText");
        nextsection.SetActive(true);

        //hide keelboat
        HideKeelboatMesh();

        // hide dinghy
        HideDinghyMesh();

        //hide yatch 
        HideYatchMesh(); 

        //show essentials 
    }

    public void BoatTextBack()
    {
        // hide boats section
        var currentsection = GameObject.Find("Canvas/SidePanel/BoatsText");
        currentsection.SetActive(false);

        // show intro text
        var previousSection = GameObject.Find("Canvas/SidePanel/IntroText");
        previousSection.SetActive(true);

        //Hide the keelboat
        HideKeelboatMesh();

        //Hide the dinghy
        HideDinghyMesh();

        //Hide the yatch 
        HideYatchMesh();

        // play sailboat animation
        ShowSailBoatMesh(); 
        PlaySailboatAnimation(); 

    }

    // since its the last section only requires going back 
    public void EssentialTextBack()
    { //hide essential text
        var currentsection = GameObject.Find("Canvas/SidePanel/EssentialsText");
        currentsection.SetActive(false);
        // show boats text
        var previousSection = GameObject.Find("Canvas/SidePanel/BoatsText");
        previousSection.SetActive(true);

        //hide essentials objects

        //show the keelboat
        ShowKeelboatMesh();
        PlayKeelboatAnimation();

        //show the dinghy
        ShowDinghyMesh();
        PlayDinghyAnimation();

        //show the yatch
        ShowYatchMesh();
        PlayYatchAnimation();
    }


    public void YesCloseButton()
    {
        Application.Quit();
    }

    public void NoCloseButton()
    {
        var closewindow = GameObject.Find("Canvas/Icons/Exit/Panel");
        closewindow.SetActive(false);
    }

    public void showCloseWidow()
    {
        var closewindow = GameObject.Find("Canvas/Icons/Exit/Panel");
        closewindow.SetActive(true);
    }

    public void ReturnHome()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Topics");
    }

    public void PlayDinghyAnimation()
    {
        dinghy = GameObject.Find("Dinghy");
        var anim = dinghy.GetComponent<Animator>();
        anim.Play("DinghyBoat");
    }

    public void PlayYatchAnimation()
    {
        yatch = GameObject.Find("Yatch");
        anim = yatch.GetComponent<Animation>();
        anim.Play();
    }

    public void PlayKeelboatAnimation()
    {
        keelboat = GameObject.Find("Keelboat");
        anim = keelboat.GetComponent<Animation>();
        anim.Play();
    }

    public void PlaySailboatAnimation()
    {
        sailboat = GameObject.Find("SailBoat");
        anim = sailboat.GetComponent<Animation>();
        anim.Play();
    }

    public void ShowDinghyMesh()
    {
        dinghy = GameObject.Find("Dinghy");
        var sail = GameObject.Find("Dinghy/sail");
        meshrenderer = dinghy.GetComponent<MeshRenderer>();
        meshrenderer.enabled = true;  
        meshrenderer= sail.GetComponent<MeshRenderer>();
        meshrenderer.enabled = true;  
    }

    public void HideDinghyMesh()
    {
        dinghy = GameObject.Find("Dinghy");
        var sail = GameObject.Find("Dinghy/sail");
        meshrenderer = dinghy.GetComponent<MeshRenderer>();
        meshrenderer.enabled = false;  
        meshrenderer= sail.GetComponent<MeshRenderer>();
        meshrenderer.enabled = false;  
    }

    public void ShowSailBoatMesh()
    {
        sailboat = GameObject.Find("SailBoat");
        meshrenderer = sailboat.GetComponent<MeshRenderer>();
        meshrenderer.enabled = true; 
    }

    public void HideSailBoatMesh()
    {
        var sailboat = GameObject.Find("SailBoat");
        meshrenderer = sailboat.GetComponent<MeshRenderer>();
        meshrenderer.enabled = false; 
    }

    public void ShowYatchMesh()
    { 
        yatch = GameObject.Find("Yatch");
        meshrenderer = yatch.GetComponent<MeshRenderer>();
        meshrenderer.enabled = true;  
    }

    public void HideYatchMesh()
    { 
        yatch = GameObject.Find("Yatch");
        meshrenderer = yatch.GetComponent<MeshRenderer>();
        meshrenderer.enabled = false;  
    }

    public void ShowKeelboatMesh()
    { 
        keelboat = GameObject.Find("Keelboat");
        meshrenderer = keelboat.GetComponent<MeshRenderer>();
        meshrenderer.enabled = true;  
    }

    public void HideKeelboatMesh()
    { 
        keelboat = GameObject.Find("Keelboat");
        meshrenderer = keelboat.GetComponent<MeshRenderer>();
        meshrenderer.enabled = false;  
    }
}
