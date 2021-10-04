using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backScene : MonoBehaviour
{
    public string Catagory;

    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void BackToCatagory()
    {
        SceneManager.LoadScene(Catagory);
    }

    
}
