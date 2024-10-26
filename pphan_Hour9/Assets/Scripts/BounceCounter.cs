using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Counter for collisions
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            counter++;
        }
        if (collision.relativeVelocity.magnitude > 2)
        {
            Debug.Log(collision.gameObject.name + " has collided " + gameObject.name + " for " + counter + " time(s).");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
