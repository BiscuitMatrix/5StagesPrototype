using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedural_Generation_AN : MonoBehaviour
{
    //Holds the different colors for the path
    public GameObject wall;
    public GameObject ground;
    public GameObject player;
    public int wallCounter;
    int counter = 0;
    float playerZPos;


    private WallBreakScript wallBreakScript;

    // Use this for initialization
    void Start()
    {
        ground.SetActive(false);
        wall.SetActive(false);
        // Setup an initial path for the player
        for (int counter = 0; counter < 70; counter++)
        {
            GameObject groundClone;
            groundClone = Instantiate(ground, new Vector3(0.0f, 0.0f, counter), Quaternion.identity);
            groundClone.gameObject.tag = "Clone";
            groundClone.SetActive(true);
        }
    }

    // Update is called once per frame
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        playerZPos = player.GetComponent<Rigidbody>().transform.position.z;
        //new Vector3 () = player.GetComponent<Transform>();
        //This sets the limit that the path can draw. Set this to be just outside the camera view

        if (counter < playerZPos + 200)
        {
            GameObject groundClone;
            groundClone = Instantiate(ground, new Vector3(0.0f, 0.0f, counter), Quaternion.identity);
            groundClone.SetActive(true);
            groundClone.gameObject.tag = "Clone";
            counter++;
        }

        if (counter % wallCounter == 0)
        {
            GameObject wallClone;
            wallClone = Instantiate(wall, new Vector3(0.0f, 2.5f, counter + 70), Quaternion.identity);
            wallClone.SetActive(true);
            wallClone.GetComponent<WallBreakScript>().break_Speed = counter / 10;
        }

        // Clean up path less
        if (counter % 2 == 0) CleanPath();



        Debug.Log(counter);
    }

    void CleanPath()
    {
        playerZPos = player.GetComponent<Rigidbody>().transform.position.z;
        GameObject[] ground = GameObject.FindGameObjectsWithTag("Clone");

        foreach (GameObject Block in ground)
        {
            if ((Block.transform.position.z + 10) < playerZPos)
            {
                GameObject holder = Block;
                Destroy(holder, 1);
            }
        }

        ground = new GameObject[0];
    }
}