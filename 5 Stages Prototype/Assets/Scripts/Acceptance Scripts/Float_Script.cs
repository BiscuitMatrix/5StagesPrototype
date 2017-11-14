//Acceptance_Script authored by Alan Guild
// This script applys the physics to the Hot Air Balloon and also works with the state of the stage.

//To Do
//-Case statement
//-use when user taps to decide on what boost
//-power bar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float_Script : MonoBehaviour
{
    public Rigidbody hotAirBalloon;
    public Transform balloonTransform;
    public Transform planetTransform;

    private bool isBoost;
    private bool isGrounded = true;

    public int noOfCanisters;


	// Update is called once per frame
	void Update ()
    {
       // TakeOff();
        ConstantSpeed();

		if(Input.GetMouseButtonDown(0))     //change to touch input     //gets user input
        {
            if(isGrounded)      //takeoff
            {
                noOfCanisters += 1;
                TakeOff();
            }
            if (!isGrounded && noOfCanisters > 0)        //choose boost    
            {
                BalloonBoost_Perfect();
            }
        }

        if (hotAirBalloon.velocity.y <= 0.0 && noOfCanisters == 0)      //ran out of canisters and decending
        {
            if (balloonTransform.position.y >= planetTransform.position.y + 5.0f)       //reached plane
            {
                reachedPlanet();
            }
            else        //not reached planet and ran out of fuel
            {
                outOfFuel();
            }
        }

        Debug.Log(hotAirBalloon.velocity);
    }

    void TakeOff()
    {
        if (isGrounded)     //initial constant take off speed
        {
            isGrounded = false;
            hotAirBalloon.AddForce(0.0f, 1.0f, 0.0f, ForceMode.Impulse);
        }
    }

    void ConstantSpeed()
    {
        if(hotAirBalloon.velocity.y < 1.0 && noOfCanisters != 0 && isGrounded == false)
        {
            hotAirBalloon.AddForce(0.0f, 2.0f, 0.0f, ForceMode.VelocityChange);
        }
    }

    void outOfFuel()
    {
        Physics.gravity = new Vector3 (0.0f, 0.0f, 0.0f);
        hotAirBalloon.AddForce(3 * Physics.gravity);
    }

    void BalloonBoost_Perfect()     //Perfect boost
    {
        isBoost = true;
        hotAirBalloon.AddForce(0.0f, 5.0f, 0.0f, ForceMode.Impulse); 

        noOfCanisters--;
        isBoost = false;
    }

    void BalloonBoost_Ok()      //Ok boost
    {
        isBoost = true;
        hotAirBalloon.AddForce(0.0f, 2.5f, 0.0f, ForceMode.Impulse); 

        noOfCanisters--;
        isBoost = false;
    }

    void BalloonBoost_Bad()     //Bad boost
    {
        isBoost = true;
        hotAirBalloon.AddForce(0.0f, 1.5f, 0.0f, ForceMode.Impulse); 

        noOfCanisters--;
        isBoost = false;
    }

    void TankEmpty()        //not Tapped in time, all tanks empty
    {
        isBoost = true;
        noOfCanisters = 0;

        isBoost = false;
    }

    void reachedPlanet()        //reached the new reality
    {

    }
}
