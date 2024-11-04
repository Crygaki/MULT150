using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    int counter = 0;
    public bool isSolvedChaos = false;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Chaos"))
        {
            Destroy(other.gameObject);
            counter++;
        }
        if(counter == 5)
        {
            isSolvedChaos = true;
            GetComponent<Light>().enabled = false;
        }
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
