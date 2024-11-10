using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        float posVar = 0.0f;

        for(int i = 0; i<20; i = i + 2)
        {
            //Convert integer to float for position arithemtic
            posVar = 9f-(float)i;

            Instantiate<GameObject>(prefab, new Vector3(posVar, 2f, -9f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Whenever we hit the B key, we will generate a prefab at the 
        //position of the original prefab
        //Whenever we hit the space key, we will generate a prefab at the 
        //position of the spawn object that this script is attached to
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
