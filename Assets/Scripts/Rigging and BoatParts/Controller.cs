using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public Transform wordscontainer;
    public Image image;
    public Animator anim;

    // Use this for initialization

    void Start()
    {
        anim = GameObject.Find("Main Camera").GetComponent<Animator>();
    }

    public void IntroTextNext()
    {
        //hide current text 
        GameObject.Find("Canvas/SidePanel/IntroText").SetActive(false);

        //show next text 
        GameObject.Find("Canvas/SidePanel/BirdsEyeViewText").SetActive(true);

        // play the next animation 
        anim.SetTrigger("Pressed1");

        // display the keywords and wind image 
        DisplayBIVText();
        DisplayBIVImage();

    }

    public void BirdEyeViewNext()
    {
        // hide the descriptions
        HideBowText();
        HideAsternText();
        HideLeewardText();
        HideWindwardText();
        HidePortText();
        HideStarboardText();

        // hide the keywords and image

        HideBIVText();
        HideBIVImage(); 

        //hide current section 
        GameObject.Find("Canvas/SidePanel/BirdsEyeViewText").SetActive(false);

        //show sideview panel

        GameObject.Find("Canvas/SidePanel/SideViewText").SetActive(true);

        //run the animation
        anim.SetTrigger("Pressed2");

        //show the keywords after animation plays 
       
            DisplaySPKWords();
       
    }

    public void BirdEyeViewBack()
    {
        //hide the descriptions
        // hide the keywords//
        //display intro section
    }

    public void SideViewTextNext()
    {
        //hide all of birds eye view section 
        HideSPKWords();
        //hide sidepanel section
        GameObject.Find("Canvas/SidePanel/SideViewText").SetActive(false);
        //show rigging text 
        GameObject.Find("Canvas/SidePanel/Rigging").SetActive(true);
        //
    }

    public void SideViewTextBack()
    {

    }

    public void DisplaySPKWords()
    {
        //Displays the keywords texts in BIVKeywords
        wordscontainer = GameObject.Find("Canvas/SPKeywords").GetComponent<Transform>();
        foreach (Transform keyword in wordscontainer)
        {
            keyword.gameObject.SetActive(true);
        }
    }

    public void HideSPKWords()
    {
        //Displays the keywords texts in BIVKeywords
        wordscontainer = GameObject.Find("Canvas/SPKeywords").GetComponent<Transform>();
        foreach (Transform keyword in wordscontainer)
        {
            keyword.gameObject.SetActive(false);
        }
    }

    public void DisplayBIVText()
    {
        //Displays the keywords texts in BIVKeywords
        wordscontainer = GameObject.Find("Canvas/BIVKeywords").GetComponent<Transform>();
        foreach (Transform keyword in wordscontainer)
        {
            keyword.gameObject.SetActive(true);
        }
    }

    public void HideBIVText()
    {
        //Displays the keywords texts in BIVKeywords
        wordscontainer = GameObject.Find("Canvas/BIVKeywords").GetComponent<Transform>();
        foreach (Transform keyword in wordscontainer)
        {
            keyword.gameObject.SetActive(false);
        }
    }

    public void DisplayBIVImage()
    {
        // display image
        var windImg = GameObject.Find("Canvas/BIVImage");
        image = windImg.GetComponent<Image>();
        image.enabled = true;

        //display the accompany text 
        GameObject.Find("Canvas/BIVImage/Wind").SetActive(true);
    }

    public void HideBIVImage()
    {
        // display image
        var windImg = GameObject.Find("Canvas/BIVImage");
        image = windImg.GetComponent<Image>();
        image.enabled = false;

        //display the accompany text 
        GameObject.Find("Canvas/BIVImage/Wind").SetActive(false);
    }

    public void DisplayBowText()
    {
        GameObject.Find("Canvas/BIVKeywords/Bow/description").SetActive(true);
    }
     
    public void HideBowText()
    {
        GameObject.Find("Canvas/BIVKeywords/Bow/description").SetActive(false);
    }

    public void DisplayLeewardText()
    {
        GameObject.Find("Canvas/BIVKeywords/Leeward/description").SetActive(true);
    }

    public void HideLeewardText()
    {
        GameObject.Find("Canvas/BIVKeywords/Leeward/description").SetActive(false);
    }

    public void DisplayStarboardText()
    {
        GameObject.Find("Canvas/BIVKeywords/Starboard/description").SetActive(true);
    }

    public void HideStarboardText()
    {
        GameObject.Find("Canvas/BIVKeywords/Starboard/description").SetActive(false);
    }

    public void DisplayAsternText()
    {
        GameObject.Find("Canvas/BIVKeywords/Astern/description").SetActive(true);
    }

    public void HideAsternText()
    {
        GameObject.Find("Canvas/BIVKeywords/Astern/description").SetActive(false);
    }

    public void DisplayPortText()
    {
        GameObject.Find("Canvas/BIVKeywords/Port/description").SetActive(true);
    }

    public void HidePortText()
    {
        GameObject.Find("Canvas/BIVKeywords/Port/description").SetActive(false);
    }

    public void DisplayWindwardText()
    {
        GameObject.Find("Canvas/BIVKeywords/Windward/description").SetActive(true);
    }

    public void HideWindwardText()
    {
        GameObject.Find("Canvas/BIVKeywords/Windward/description").SetActive(false);
    }

    public void DisplayHeadText()
    {
        GameObject.Find("Canvas/SPKeywords/Head/description").SetActive(true);
    }

    public void HideHeadText()
    {
        GameObject.Find("Canvas/SPKeywords/Head/description").SetActive(false);
    }

    public void DisplayCentreBoardText()
    {
        GameObject.Find("Canvas/SPKeywords/CentreBoard/description").SetActive(true);
    }

    public void HideCentreBoardText()
    {
        GameObject.Find("Canvas/SPKeywords/CentreBoard/description").SetActive(false);
    }

    public void DisplayRudderText()
    {
        GameObject.Find("Canvas/SPKeywords/Rudder/description").SetActive(true);
    }

    public void HideRudderText()
    {
        GameObject.Find("Canvas/SPKeywords/Rudder/description").SetActive(false);
    }

    public void DisplayTillerText()
    {
        GameObject.Find("Canvas/SPKeywords/Tiller/description").SetActive(true);
    }

    public void HideTillerText()
    {
        GameObject.Find("Canvas/SPKeywords/Tiller/description").SetActive(false);
    }

    public void DisplayMainSailText()
    {
        GameObject.Find("Canvas/SPKeywords/MainSail/description").SetActive(true);
    }

    public void HideMainSailText()
    {
        GameObject.Find("Canvas/SPKeywords/MainSail/description").SetActive(false);
    }

    public void DisplayBoomText()
    {
        GameObject.Find("Canvas/SPKeywords/Boom/description").SetActive(true);
    }

    public void HideBoomText()
    {
        GameObject.Find("Canvas/SPKeywords/Boom/description").SetActive(false);
    }

    public void DisplayMastText()
    {
        GameObject.Find("Canvas/SPKeywords/Mast/description").SetActive(true);
    }

    public void HideMastText()
    {
        GameObject.Find("Canvas/SPKeywords/Mast/description").SetActive(false);
    }

    public void DisplayHalyardText()
    {
        GameObject.Find("Canvas/SPKeywords/Halyard/description").SetActive(true);
    }

    public void HideHalyardText()
    {
        GameObject.Find("Canvas/SPKeywords/Halyard/description").SetActive(false);
    }
}
