using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class den_ProceduralGeneration : MonoBehaviour 
{
    public GameObject [] paths = new GameObject[3];

	public int width;
	public int length;

	public string seed;
	public bool useRandomSeed;

	[Range(0,100)]
	public int randomFillPercent;

	// Creates an empty array to represent the path
	int[,] path;


	void Start () 
	{
		// Setup how new blocks are going to enter the game
		//generatePath();


	}
	
	// Update is called once per frame
	void Update () 
	{
		// When an old set of blocks is out of view
			// 1. Delete the Old Blocks

			// 2. Instantiate new blocks into the scene
		
	}



















    /*
	void generatePath () 
	{
		path = new int[width,length];
		randomFillPath();

		for(int i = 0; i < 5; i++)
		{
			pathRules ();
		}
	} // End of Generate Path

    // Sets how the path will be made
	void randomFillPath()
	{
		if (useRandomSeed) 
		{
			seed = Time.time.ToString();
		}

		// sets up the pseudo-random number generator
		System.Random prng = new System.Random (seed.GetHashCode());
	
        // For each 
		for (int y = 0; y < length; y++) 
		{
			for (int x = 0; x < width; x++)
            {
				// Randomly generates numbers between 0 and 100
				// Takes the fill percentage value and determines based on that if there is a tile or not.
				// 1 = Tile		0 = No Tile
				path [x, y] = (prng.Next (0, 100) < randomFillPercent) ? 1 : 0;

                if (path[x, y] == 1) Instantiate(den_ProcGenPath, new Vector3 (x,y,1), transform.rotation);
			}
		}
	} //  End of randomFillPath

	void pathRules()
	{
		for (int x = 0; x < width; x++) 
		{
			for (int y = 0; y < length; y++) 
			{
				int neighbours = detectPathSurroundings(x, y);


				if (neighbours > 4) 
				{
					path [x, y] = 1;
				} 
				else if (neighbours < 4) 
				{
					path [x, y] = 0;
				}
			}
		}
	} // End of pathRules

	int detectPathSurroundings(int posX, int posY)
	{
		int neighbourCount = 0;
		for (int neighbourX = (posX - 1); neighbourX <= (posX + 1); neighbourX++) 
		{
			for (int neighbourY = (posY - 1); neighbourY <= (posY + 1); neighbourY++) 
			{
				if ((neighbourX >= 0) && (neighbourX < width) && (neighbourY >= 0) && (neighbourY < length)) 
				{
					if ((neighbourX != posX) || (neighbourY != posY)) 
					{
						neighbourCount += path [neighbourX, neighbourY];
					}
				} 
				else neighbourCount++;
			}
		}

		return neighbourCount;
	} // End of detectPathSurroundings

	void OnDrawGizmos ()
	{
		if (path != null) 
		{
			for (int x = 0; x < width; x++) 
			{
				for (int y = 0; y < length; y++) 
				{
					// Replace Gizmos with your own object
					Gizmos.color = (path[x,y] == 1)? Color.black : Color.white;
					Vector3 pos = new Vector3 (((-width / 2) + x + 0.5f), 0, ((-length / 2) + y + 0.5f));
					Gizmos.DrawCube (pos, Vector3.one);
				}
			}
		}
	} // End of onDrawPath
    */
}
