//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;
    public Transform cylinder;
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        // random colour for the scene cube and transparency set to 0.4
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Material mat = GetComponent<Renderer>().material;
        mat.color = new Color(r, g, b, 0.4f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();  
        }
        
    }

    void Spawn()
    {
        
        Transform[] prefab = new Transform[] { cylinder, sphere, cube };

        Transform clone = Instantiate(prefab[Random.Range(0,3)], new Vector3(0, 0, 0), Quaternion.identity);

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Material mat = clone.GetComponent<Renderer>().material;
        mat.color = new Color(r, g, b, 1f);

        float scale = Random.Range(1f, 5f);
        clone.transform.localScale = new Vector3(scale, scale, scale);

        


    }
}
