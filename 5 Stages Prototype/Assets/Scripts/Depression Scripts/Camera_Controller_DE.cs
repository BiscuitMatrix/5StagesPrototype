using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_Controller_DE : MonoBehaviour {

    public GameObject Player;

    private Vector3 Player_Offset;

	// Use this for initialization
	void Start ()
    {
        Player_Offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        // Follow the player, keeping the same initial offset from player's transform - J
        transform.position = Player.transform.position + Player_Offset;

        // Do not follow the player down under the lake's surface - J
        if (transform.position.y < 2f)
        {
            transform.position.Set(transform.position.x, 2f, transform.position.z);
        }
	}
}
