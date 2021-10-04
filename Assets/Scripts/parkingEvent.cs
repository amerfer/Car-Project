using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class parkingEvent : MonoBehaviour
{
    //public GameObject triggerObject;
    public GameObject Wheels;
    public Rigidbody carTarget;
    public GameObject destroyGameObject;
    //public GameObject congratsObject;
    public GameObject closeText;
    //public GameObject congratsText;
    //public Button backButton;
    //private float Stopspeed = 0.0f;
    public string finishLevel;

    public void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = false;
        //congratsObject.SetActive(false);
    }


    void OnCollisionEnter (Collision colliderTrigger)
    {
            if (colliderTrigger.collider.tag == Wheels.tag)
            {
            carTarget.velocity = Vector3.zero;
            Debug.Log("SUCCESS, YOUR ARE NOW PARKED");
            Cursor.visible = true;
            SceneManager.LoadScene(finishLevel);


        }
    }
    

  
}
