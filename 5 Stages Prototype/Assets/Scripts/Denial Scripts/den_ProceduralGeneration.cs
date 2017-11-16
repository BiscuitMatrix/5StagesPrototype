using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class den_ProceduralGeneration : MonoBehaviour
{
	//Holds the different colors for the path
	public GameObject [] paths = new GameObject[4];
	public GameObject player;
	public int renderDistance;
	int counter = 70;
    float playerZPos;
	//static float objectOffset = (/* get the z scale of the object */ / 2) - 0.5f;

    // Use this for initialization
    void Start ()
	{
        // Setup an initial path for the player
		for (int i = 0; i < renderDistance; i++)
		{
			for (float width = 0; width < 4; width++)
			{
				int holder = (int)width;

				Instantiate(paths[holder], new Vector3(width, 0.0f, i), Quaternion.identity);
            }
		}
		Debug.Break ();
	}


    void Update ()
	{
        playerZPos = player.GetComponent<Rigidbody>().transform.position.z;
        //new Vector3 () = player.GetComponent<Transform>();
        //This sets the limit that the path can draw. Set this to be just outside the camera view
        
        if (counter < playerZPos + 70)
		{
			//Draw from left to right. Should be updated to sometimes not add to make holes in path
			for (float width = 0; width < 4; width++)
			{
				int holder = (int)width;
				Instantiate(paths[holder], new Vector3(width, 0.0f, counter), Quaternion.identity);
			}
            counter++;
        }
        
		// Clean up path less
		if(counter % 2 == 0) CleanPath();
       

        
        Debug.Log(counter);
    }

    void CleanPath()
    {
        playerZPos = player.GetComponent<Rigidbody>().transform.position.z;
        GameObject[] objects = GameObject.FindGameObjectsWithTag("den_Path");

        foreach (GameObject Block in objects)
        {
            if ((Block.transform.position.z + 3) < playerZPos)
            {
                GameObject holder = Block;
                Destroy(holder, 1);
            }
        }

        objects = new GameObject[0];
    }
}
















