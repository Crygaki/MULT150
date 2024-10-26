using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseTriggerScript : MonoBehaviour
{
    //Trigger on Enter
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered " + gameObject.name + ".");
    }

    //Trigger on Stay
    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in " + gameObject.name + ".");
    }

    //Trigger on Exit
    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left " + gameObject.name + ".");
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
