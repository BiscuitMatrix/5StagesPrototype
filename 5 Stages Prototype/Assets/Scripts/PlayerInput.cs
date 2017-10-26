using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Variable Declarations
    public float constVel = 0.5f;

    // Function Declarations
    //void autoMove();
    //void input();


    // Use this for initialization
    void Start()
    {
        //autoMove();
    }

    // Update is called once per frame
    void Update()
    {
		//transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //input();
    }


    void autoMove()
    {
        //vel.x = constVel;
    }

    void mobileInput()
    {
        // Detect and remember input
        Touch myTouch = Input.GetTouch(0);
        myTouch.fingerId;
        myTouch.position;
		myTouch.phase;
        // How do you represent a swipe in code?
			// Take the difference in position over time
        Vector2 touchDeltaPosition = myTouch.deltaPosition;
        
        // Compare
        // Justin was 'ere., 2k17
        if (touchDeltaPosition.x < 0.0f) // Swipe Left  (-ve x val) 
        {
            // Is there a path on the left?

            // If there is, move player to path on the left
            // If not, do nothing
        }
        else if (touchDeltaPosition.x > 0.0f) // Swipe Right (+ve x val) 
        {
            // Is there a path on the right?

            // If there is, move player to path on the right
            // If not, do nothing
        }

    } // End Input

    void desktopInput()
    {
		if( keypress. Left)
		{
			
		}
    }

}