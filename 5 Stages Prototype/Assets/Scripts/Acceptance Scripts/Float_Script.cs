using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float_Script : MonoBehaviour
{
    public Rigidbody hotAirBalloon;

    //public GameObject fuelBar;

    //private float fuel = 100.0f;
	
	// Update is called once per frame
	void Update ()
    {
        //while (fuelBar.transform.position != new Vector3(0.0f, -0.5f, 0.0f))
        //{
        //    fuelBar.transform.position = new Vector3(0.0f, fuelBar.transform.position.y - 1, 0);
        //}

		if(Input.GetMouseButtonDown(0))
        {
            hotAirBalloon.AddForce(0, 5, 0, ForceMode.VelocityChange); //boost
            Debug.Log(hotAirBalloon.velocity);
        }
	}
}
