using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour 
{
    private GameObject aboutWindow;

  public void SceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex); 
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void ShowHelpMenu()
    {
        aboutWindow = GameObject.Find("Canvas/Group3/Panel");
        aboutWindow.SetActive(true);//show the about window
    }

    public void HideHelpMenu()
    {
        aboutWindow = GameObject.Find("Canvas/Group3/Panel");
        aboutWindow.SetActive(false);//show the about window
    }

}
