using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class den_PlayerInput : MonoBehaviour
{

	// Variable Declarations
	public float constVel;
	// Each stage requires a different velocity as the game increases in pace
	public float S1maxVel;
	public float S2maxVel;

	private float laneswitch;

	void Start()
	{
		// Set the distance the player will go when swiping left or right
		laneswitch = 1.0f;
	}

	// Update is called once per frame
	void Update()
	{
		// This is the players 
		transform.Translate(Vector3.forward * constVel * Time.deltaTime);
		if (constVel < S1maxVel) 
		{
			constVel += (0.1f * Time.deltaTime);
		}


		desktopInput();
		mobileInput();
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
			transform.Translate(Vector3.left * laneswitch);
			// If not, do nothing
		}
		else if (touchDeltaPosition.x > 1.0f) // Swipe Right (+ve x val) 
		{
			// move player to path on the right
			transform.Translate(Vector3.right * laneswitch);
			// If not, do nothing
		}

	} // End Input

	void desktopInput()
	{
		if (Input.GetKeyDown("a")) // Player "swipes" left
		{
			// move player to path on the left
			transform.Translate(Vector3.left * laneswitch);
			// If not, do nothing
		}
		if (Input.GetKeyDown("d")) // Player "swipes" right
		{
			// move player to path on the right
			transform.Translate(Vector3.right * laneswitch);
			// If not, do nothing
		}
	}

}