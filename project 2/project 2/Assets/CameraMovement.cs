using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 150f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        if (Input.GetKey(KeyCode.Q))
        {
            move.y += 1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            move.y -= 1;
        }
        controller.Move(move * speed * Time.deltaTime);
    }
}
