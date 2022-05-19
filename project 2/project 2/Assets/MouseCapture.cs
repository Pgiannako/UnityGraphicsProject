using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCapture : MonoBehaviour
{
    public float mouseSpeed = 100f; //speed of the camera
    public Transform cameraBody; // public var to link the Main camera with the FPS
    float axisXrotation = 0f; // initial rotation angle 

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // locking mouse cursor to center of scene
    }

    // Update is called once per frame
    void Update()
    {
        float axisX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float axisY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        axisXrotation -= axisY; // if its += its flipped
        axisXrotation = Mathf.Clamp(axisXrotation, -90f, 90f);                // clamping the X rotation to 180 degrees of movement, 
        transform.localRotation = Quaternion.Euler(axisXrotation, 0f, 0f);    // to not see the "back" of the camera, then using  Quaternions for rotation
        cameraBody.Rotate(Vector3.up * axisX);
    }
}
