using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // Get the distance between the player and the camera, used to keep the distance constant
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after Update
	void LateUpdate () {
        // Move with the player

        transform.position = player.transform.position + offset;
	}
}
