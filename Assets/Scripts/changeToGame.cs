using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeToGame : MonoBehaviour
{
    public string reverse;
    public string forward;

    public void reverseScene()
    {
        //backButton.interactable = true;
        SceneManager.LoadScene(reverse);
    }

    public void forwardScene()
    {
        //backButton.interactable = true;
        SceneManager.LoadScene(forward);
    }
}
