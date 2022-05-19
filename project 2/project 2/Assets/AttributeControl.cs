using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeControl : MonoBehaviour
{

    public Rigidbody spw;
    public GameObject obj;
    public MeshRenderer mesh;
    float speed = 50;
    public GameObject scnCube;

    // Start is called before the first frame update
    void Start()
    {
        scnCube = GameObject.FindWithTag("scnCube");

        if (obj.name == "spawnCube" || obj.name == "spawnSphere" || obj.name == "spawnCylinder") 
        {
            mesh.enabled = false;
            return;
        
        }
        mesh.enabled = true;
        //Debug.Log(obj.name);

        spw.AddForce(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

    }

    // Update is called once per frame
    void Update()
    {
        speed = scnCube.GetComponent<speedHandler>().speed;
        spw.velocity = spw.velocity.normalized * speed * Time.deltaTime;
    }
}
