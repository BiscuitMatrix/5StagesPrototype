using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_Of_Traps_DE : MonoBehaviour {

    public GameObject[] Traps;
    public GameObject Destroy_Point;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {

        Traps = GameObject.FindGameObjectsWithTag("Trap");
        //foreach ()
    }
}
