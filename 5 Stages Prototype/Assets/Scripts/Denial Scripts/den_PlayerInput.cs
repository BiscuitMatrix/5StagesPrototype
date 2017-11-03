using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class den_PlayerInput : MonoBehaviour
{

	// Variable Declarations
	private float constVel = 0.5f;
	// Each stage requires a different velocity as the game increases in pace
	private float S1maxVel = 2.0f;
	private float S2maxVel = 4.0f;
	private float swipeSpeed = 1.0f;

	// Function Declarations



	// Use this for initialization
	void Start()
	{
		// What things need initialising?
	}

	// Update is called once per frame
	void Update()
	{
		// This is the players 
		transform.Translate(Vector3.forward * constVel * Time.deltaTime);
		if (constVel < maxVel) 
		{
			constVel += (0.1f * Time.deltaTime);
		}


		desktopInput();
	}


	void mobileInput()
	{
		// Detect and remember input
		Touch myTouch = Input.GetTouch(0);
		//		myTouch.fingerId;
		//		myTouch.position;
		//		myTouch.phase;
		// How do you represent a swipe in code?
		// Take the difference in position over time
		Vector2 touchDeltaPosition = myTouch.deltaPosition;

		// Compare
		if (touchDeltaPosition.x < -1.0f) // Swipe Left  (-ve x val) 
		{
			// move player to path on the left
			transform.Translate(Vector3.left * swipeSpeed);
			// If not, do nothing
		}
		else if (touchDeltaPosition.x > 1.0f) // Swipe Right (+ve x val) 
		{
			// move player to path on the right
			transform.Translate(Vector3.right * swipeSpeed);
			// If not, do nothing
		}

	} // End Input

	void desktopInput()
	{
		if (Input.GetKeyDown("a")) // Player "swipes" left
		{
			// move player to path on the left
			transform.Translate(Vector3.left * swipeSpeed);
			// If not, do nothing
		}
		if (Input.GetKeyDown("d")) // Player "swipes" right
		{
			// move player to path on the right
			transform.Translate(Vector3.right * swipeSpeed);
			// If not, do nothing
		}
	}

}