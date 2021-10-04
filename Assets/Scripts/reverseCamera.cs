using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float c_Yposition = transform.rotation.y;
        int new_Yposition = 0;

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (c_Yposition != -180 || c_Yposition != 0)
            {
                new_Yposition = 180;
                c_Yposition = new_Yposition;
               // transform.rotation = Quaternion.Euler(0, c_Yposition, 0);
                transform.Rotate(0, c_Yposition, 0);
            }
            
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            new_Yposition = 90;
            transform.Rotate(new Vector3(0, new_Yposition, 0));
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            new_Yposition = 270;
            transform.Rotate(new Vector3(0, new_Yposition, 0));
        }
    }
}
