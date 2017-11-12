using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float_Script : MonoBehaviour
{
    public Rigidbody hotAirBalloon;

    private bool isBoost;
    private bool isGrounded = true;
	
	// Update is called once per frame
	void Update ()
    {
        if (isGrounded)     //initial constant take off speed
        {
            isGrounded = false;
            hotAirBalloon.AddForce(0.0f, 0.5f, 0.0f, ForceMode.VelocityChange);
        }

		if(Input.GetMouseButtonDown(0))
        {
            BalloonBoosts();
        }

        //if(hotAirBalloon.velocity.y > 0.0 && !isBoost)        
        //{
        //    hotAirBalloon.AddForce(3 * Physics.gravity);
        //}

        Debug.Log(hotAirBalloon.velocity);
    }

    void BalloonBoosts()
    {
        isBoost = true;
        hotAirBalloon.AddForce(0, 5, 0, ForceMode.VelocityChange); //boost
        isBoost = false;
    }
}
