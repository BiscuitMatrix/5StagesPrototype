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

    public bool freezeX;
    public bool freezeY;
    public bool freezeZ;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (!freezeX && !freezeY && !freezeZ)       //freeze none
        {
            Follower.transform.position = new Vector3(ToFollow.transform.position.x + offsetX, ToFollow.transform.position.y + offsetY, ToFollow.transform.position.z + offsetZ);
        }
        else if ( freezeX && !freezeY && !freezeZ)      //freeze X
        {
            Follower.transform.position = new Vector3(Follower.transform.position.x, ToFollow.transform.position.y + offsetY, ToFollow.transform.position.z + offsetZ);
        }
        else if(!freezeX && freezeY && !freezeZ)        //freeze Y
        {
            Follower.transform.position = new Vector3(ToFollow.transform.position.x + offsetX, Follower.transform.position.y, ToFollow.transform.position.z + offsetZ);
        }
        else if(!freezeX && !freezeY && freezeZ)        //freeze Z
        {
            Follower.transform.position = new Vector3(ToFollow.transform.position.x + offsetX, ToFollow.transform.position.y + offsetY, Follower.transform.position.z);
        }
        else if(freezeX && freezeY && !freezeZ)     //freeze X & Y
        {
            Follower.transform.position = new Vector3(Follower.transform.position.x, Follower.transform.position.y, ToFollow.transform.position.z + offsetZ);
        }
        else if(freezeX && !freezeY && freezeZ)     //freeze X & Z
        {
            Follower.transform.position = new Vector3(Follower.transform.position.x, ToFollow.transform.position.y + offsetY, Follower.transform.position.z);
        }
        else if(!freezeX && freezeY && freezeZ)     //freeze Y & Z
        {
            Follower.transform.position = new Vector3(ToFollow.transform.position.x + offsetX, Follower.transform.position.y, Follower.transform.position.z);
        }
	}
}
