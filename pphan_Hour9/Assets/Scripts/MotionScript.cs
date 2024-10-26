using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Use the arrows (Left, Right, Up, Down) for moving the object on screen.
    	float mX = Input.GetAxis ("Horizontal")/512;
		float mY = Input.GetAxis ("Vertical")/512;

		transform.Translate (mX, mY , 0);
    }
}
