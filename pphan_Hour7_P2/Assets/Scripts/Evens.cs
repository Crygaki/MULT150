using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int evenNumber = 22; evenNumber <= 100; evenNumber = evenNumber + 2)
        {
            Debug.Log(evenNumber);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
