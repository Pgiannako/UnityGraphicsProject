using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class SPHtexture : MonoBehaviour
{

    string path = "image.jpg";

    byte[] fileData;

    bool toggle = false;

    Texture2D texture = null;

    // Start is called before the first frame update
    void Start()
    {
        

        if (File.Exists(path))
        {
            fileData = File.ReadAllBytes(path);
            texture = new Texture2D(2, 2);
            texture.LoadImage(fileData);
            GetComponent<Renderer>().material.mainTexture = texture;
        }
        else //debug code TODO remove it from final build
        {
            string dir = Directory.GetCurrentDirectory();
            Debug.Log("no image");
            Debug.Log(dir);


        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {

            toggle = !toggle;

        }
        if (toggle == true)
        {

            GetComponent<Renderer>().material.color = new Color(1,1,1,1);
            GetComponent<Renderer>().material.mainTexture = texture;

        }
        else
        {

            GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
            GetComponent<Renderer>().material.mainTexture = null;

        }
    }
}
