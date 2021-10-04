using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carSpeed : MonoBehaviour
{
    public Rigidbody carTarget;
    

    public float maxSpeed = 0.0f; // The maximum speed of the target ** IN MPH **

    //public float minSpeedArrowAngle;
    //public float maxSpeedArrowAngle;

    [Header("UI")]
    public Text speedLabel; // The label that displays the speed;
   /* public RectTransform arrow;*/ // The arrow in the speedometer

    private float speed = 0.0f;



    // Update is called once per frame
    void Update()
    {
        //takes the car's speed
        speed = carTarget.velocity.magnitude * 2.5f; 

        if (speedLabel != null)
            speedLabel.text = ((int)speed) + " MPH";
    }
}
