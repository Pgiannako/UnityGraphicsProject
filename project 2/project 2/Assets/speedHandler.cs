using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedHandler : MonoBehaviour
{

    public float speed = 10000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Period) && speed < 35000f) // speed up
        {
            Debug.Log(speed);
            speed = speed + 100;

        }
        if (Input.GetKey(KeyCode.Comma) && speed > 100f) // speed down
        {
            Debug.Log(speed);
            speed = speed - 100;

        }
    }
}