using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    //Trigger on Enter
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the cube");
    }

    //Trigger on Stay
    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the cube");
    }

    //Trigger on Exit
    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the cube");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
