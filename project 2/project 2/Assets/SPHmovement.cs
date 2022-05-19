using UnityEngine;
using System.Collections;



public class SPHmovement : MonoBehaviour
{

    public Rigidbody sph;
    int x;
    int y;
    int z;
    //The speed the Sphere is moving with
    int speed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // "Fixed" because physics react better than in the standard "Update"
    void FixedUpdate()
    {
    
        x = 0;
        y = 0;
        z = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            x = x - speed;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            x = x + speed;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            y = y + speed;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            y = y - speed;

        }
        if (Input.GetKey("-"))
        {

            z = z - speed;

        }
        if (Input.GetKey("="))
        {

            z = z + speed;
        }
        // Apply the velocities to the sphere for this frame
        sph.velocity = new Vector3(x, y, z);

    }
}
