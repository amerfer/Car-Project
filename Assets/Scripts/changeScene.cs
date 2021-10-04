using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public string levelName; //The scene that's going to change
    public string reverse;
    public string forward;
    public Button backButton;

    public void nextScene()
    {
        //backButton.interactable = true;
        SceneManager.LoadScene(levelName);
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
