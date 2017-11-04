using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float_Script : MonoBehaviour
{
    public Rigidbody hotAirBalloon;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            hotAirBalloon.AddForce(0, 5, 0, ForceMode.VelocityChange); //boost
            Debug.Log(hotAirBalloon.velocity);
        }
	}
}
