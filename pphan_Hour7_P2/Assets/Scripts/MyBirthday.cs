using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    // My birthday is January 1.
    void Start()
    {
        for(int dayNum = 1; dayNum <=31; dayNum++)
        {
            if(dayNum == 1)
            {
                Debug.Log("January " + dayNum + " is my birthday!");
            }
            else
            {
                Debug.Log("January " + dayNum);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
