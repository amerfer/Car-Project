using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catagoryChangeScene : MonoBehaviour
{
    public string maneuversName; //The scene that's going to change
    public string courseName;

    public void ChangeToManeuvers()
    {
        SceneManager.LoadScene(maneuversName);
    }

    public void ChangeToCourses()
    {
        SceneManager.LoadScene(courseName);
    }
}
