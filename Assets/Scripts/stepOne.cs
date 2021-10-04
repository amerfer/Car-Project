using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stepOne : MonoBehaviour

{
    public Rigidbody carTarget;
    public GameObject backWheels;

    public GameObject arrow;
    public GameObject step_1; //
    public GameObject step_2; //

    public GameObject step_1_text;
    public GameObject step_2_text;


    // Start is called before the first frame update
    void Start()
    {
        arrow.SetActive(true);
        step_1.SetActive(true);
        step_1_text.SetActive(true);

        step_2.SetActive(false);
        step_2_text.SetActive(false);

    }

    void OnCollisionEnter(Collision colliderTrigger)
    {
        if (colliderTrigger.collider.tag == backWheels.tag)
        {
            Debug.Log("Car is aligned");
            carTarget.velocity = Vector3.zero;

            //Turn off these gameObjects
            step_1.SetActive(false);
            arrow.SetActive(false);
            step_1_text.SetActive(false);

            //Turn on these gameObjects
            step_2.SetActive(true);
            step_2_text.SetActive(true);
        }
    }
}
