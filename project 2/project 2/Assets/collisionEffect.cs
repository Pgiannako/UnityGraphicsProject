using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEffect : MonoBehaviour
{

    //public Transform cube;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
       // ContactPoint contacts = collision.contacts[0];
       // Debug.Log("collision");
        //Instantiate(cube, contacts.point, Quaternion.identity);
        audioSource.Play();
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.white);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
