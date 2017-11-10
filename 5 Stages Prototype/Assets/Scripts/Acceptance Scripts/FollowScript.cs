using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public GameObject ToFollow;
    public GameObject Follower;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Follower.transform.position = new Vector3(Follower.transform.position.x, ToFollow.transform.position.y + 1.5f, Follower.transform.position.z);
	}
}
