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

	public float constRot;
	public float S1maxRot;
	public float S2maxRot;

	private Vector2 startPos;
	private Vector2 direction;
	private bool directionChosen = false;

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
			transform.Rotate(Vector3.forward *  * Time.deltaTime);
		}


		desktopInput();
		mobileInput();
	}


	void mobileInput()
	{ 
		// Detect and remember input
		Touch myTouch = Input.GetTouch(0);

		// Track a single touch as a direction control.
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);

			// Handle finger movements based on touch phase.
			switch (touch.phase)
			{
			// Record initial touch position.
			case TouchPhase.Began:
				startPos.x = touch.position.x;
				directionChosen = false;
				break;

				// Determine direction by comparing the current touch position with the initial one.
			case TouchPhase.Moved:
				direction.x = touch.position.x - startPos.x;
				break;

				// Report that a direction has been chosen when the finger is lifted.
			case TouchPhase.Ended:
				directionChosen = true;
				break;
			}
		}
		if (directionChosen == true)
		{
			// Something that uses the chosen direction...
			// Compare
			if (direction.x < -1.0f) // Swipe Left  (-ve x val) 
			{
				// move player to path on the left
				transform.Translate(Vector3.left * laneswitch);
				directionChosen = false;
			}
			else if (direction.x > 1.0f) // Swipe Right (+ve x val) 
			{
				// move player to path on the right
				transform.Translate(Vector3.right * laneswitch);
				directionChosen = false;
			}
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