using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class den_MainCamera : MonoBehaviour {

    public GameObject player;
	private float zOffset;

    void Start () {
		// Calculate the cameras offset from the player object
        zOffset = transform.position.z - player.transform.position.z;
    }

	void Update () {
		// Update the z-position of the camera based on this offset and the players current position
        transform.position = new Vector3 (
			transform.position.x,					// x
			transform.position.y,					// y
			zOffset + player.transform.position.z);	// z
    }
		
}
