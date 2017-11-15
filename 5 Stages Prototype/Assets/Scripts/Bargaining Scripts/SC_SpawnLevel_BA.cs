﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_SpawnLevel_BA : MonoBehaviour {

    public GameObject[] leaf;
    public Camera cam;
    private Vector3 lastLeafPosition;
    private int randLeaf;
    // Use this for initialization
    void Start()
    {

        lastLeafPosition = new Vector3(15.0f, 1.0f, 23.0f);
        for (int x = 0; x < 5; x++)
        {
            UpdateLevel();
        }
        
    }

	// Update is called once per frame
	void Update () {

        
    }

    public void UpdateLevel()
    {
        switch(Random.Range(0,3))
            {
            case 0:
                Instantiate(leaf[0], lastLeafPosition, Quaternion.identity);
                lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x,lastLeafPosition.x * 1.6f));
                lastLeafPosition.y = (Random.Range(lastLeafPosition.y, lastLeafPosition.y * 1.5f));
                break;
            case 1:
                Instantiate(leaf[1], lastLeafPosition, Quaternion.identity);
                lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                lastLeafPosition.y = (Random.Range(lastLeafPosition.y, lastLeafPosition.y * 1.5f));
                break;
            case 2:
                Instantiate(leaf[2], lastLeafPosition, Quaternion.identity);
                lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                lastLeafPosition.y = (Random.Range(lastLeafPosition.y, lastLeafPosition.y * 1.5f));
                break;
            case 3:
                Instantiate(leaf[3], lastLeafPosition, Quaternion.identity);
                lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                lastLeafPosition.y = (Random.Range(lastLeafPosition.y, lastLeafPosition.y * 1.5f));
                break;
        }
       
    }

   
}
