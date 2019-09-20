using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopicsController : MonoBehaviour 
{

	GameObject imageholder;
	GameObject textHolder;
    public Sprite picture;
    private static string sceneIndex;
    private bool v;

    public TopicsController(bool v)
    {
        this.v = v;
    }

	public void SailingIntroHover()
	{
		picture = Resources.Load<Sprite>("Sailing Intro");
		// set the sailing intro image 
		imageholder = GameObject.Find("Canvas/Image");
		imageholder.GetComponentInChildren<Image>().sprite = picture;
		//set the description in the text placeholder
		textHolder = GameObject.Find("Canvas/Image/TextMeshPro Text");
		textHolder.GetComponentInChildren<Text>().text = "Learn what sailing is, the different types of sailboats, safety and clothing and the 5 sailing essentials.";
		var startbtn = GameObject.Find("Canvas/Image/startbtn"); // find the appropriate GameObject
		startbtn.SetActive(true); // set it active to be shown on the GUI
		sceneIndex = "Sailing Intro"; 
	}

	public void BoatParts()
    {
		picture = Resources.Load<Sprite>("Boat Parts");
        // set the sailing intro image 
		imageholder = GameObject.Find("Canvas/Image");
        imageholder.GetComponentInChildren<Image>().sprite = picture;
        //set the description in the text placeholder
		textHolder = GameObject.Find("Canvas/Image/TextMeshPro Text");
        textHolder.GetComponentInChildren<Text>().text = "Learn and test your knowledge onthe different parts of a dinghy boat. ";
		var startbtn = GameObject.Find("Canvas/Image/startbtn"); // find the appropriate GameObject
		startbtn.SetActive(true); // set it active to be shown on the GUI
        sceneIndex = "Rigging and BoatParts"; 
}
		
    public void PointsOfSailHover()
    {
		picture = Resources.Load<Sprite>("PointOfSail 2");
		// set the sailing intro image 
		imageholder = GameObject.Find("Canvas/Image");
		imageholder.GetComponentInChildren<Image>().sprite = picture;
		//set the description in the text placeholder
		textHolder = GameObject.Find("Canvas/Image/TextMeshPro Text");
		textHolder.GetComponentInChildren<Text>().text = "Be aware of the different wind directions on your boat by learning the points of sail. ";
		var startbtn = GameObject.Find("Canvas/Image/startbtn"); // find the appropriate GameObject
		startbtn.SetActive(true); // set it active to be shown on the GUI
        sceneIndex = "Points Of Sail"; 
	}

    public void TackingGybingHover()
    {
		picture = Resources.Load<Sprite>("TackingGybing");
		// set the sailing intro image 
		imageholder = GameObject.Find("Canvas/Image");
		imageholder.GetComponentInChildren<Image>().sprite = picture;
		//set the description in the text placeholder
		textHolder = GameObject.Find("Canvas/Image/TextMeshPro Text");
		textHolder.GetComponentInChildren<Text>().text = "Tack and Gybe across the sea, learn these essential sailing manoeuvres!";
		var startbtn = GameObject.Find("Canvas/Image/startbtn"); // find the appropriate GameObject
		startbtn.SetActive(true); // set it active to be shown on the GUI
		sceneIndex = "TackAndGybe";
	}

    public void RopeworkHover()
    {
		picture = Resources.Load<Sprite>("Ropework");
		// set the sailing intro image 
		imageholder = GameObject.Find("Canvas/Image");
		imageholder.GetComponentInChildren<Image>().sprite = picture;
		//set the description in the text placeholder
		textHolder = GameObject.Find("Canvas/Image/TextMeshPro Text");
		textHolder.GetComponentInChildren<Text>().text = "Figure of Eight, Using a Cleat and Bowline. Learn these knots and ropeworks.";
		var startbtn = GameObject.Find("Canvas/Image/startbtn"); // find the appropriate GameObject
		startbtn.SetActive(true); // set it active to be shown on the GUI
        sceneIndex = "Ropework";
	}

	public void StartButtonPressed()
	{
        StartCoroutine(LoadSceneCarefully());
	}

    IEnumerator LoadSceneCarefully()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneIndex);

        //Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
	