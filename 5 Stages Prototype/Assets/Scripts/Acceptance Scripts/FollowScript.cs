using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public GameObject ToFollow;
    public GameObject Follower;

    public float offsetX;
    public float offsetY;
    public float offsetZ;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Follower.transform.position = new Vector3(ToFollow.transform.position.x + offsetX, ToFollow.transform.position.y + offsetY, ToFollow.transform.position.z + offsetZ);
	}
}
