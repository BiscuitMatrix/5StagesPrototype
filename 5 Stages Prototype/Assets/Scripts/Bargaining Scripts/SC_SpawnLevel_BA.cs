using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_SpawnLevel_BA : MonoBehaviour {

    public GameObject[] leaf;
    public GameObject powerUp;
    public Camera cam;
    private Vector3 lastLeafPosition;
    private int randLeaf;
    private float maxY;
    // Use this for initialization
    void Start()
    {
        SetUp();
        
    }

	// Update is called once per frame
	void Update () {

        
    }

    void SetUp()
    {
        maxY = 5.4f;
        lastLeafPosition = new Vector3(15.0f, 1.0f, 23.0f);
        for (int x = 0; x < 10; x++)
        {
            UpdateLevel();
            PowerUps();
        }
    }
    public void UpdateLevel()
    {
        switch(Random.Range(0,3))
            {
            case 0:
                if (leaf[0] != null)
                {
                    Instantiate(leaf[0], lastLeafPosition, Quaternion.identity);
                    lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                    lastLeafPosition.y = (Random.Range(lastLeafPosition.y, maxY));
                }
                    break;
            case 1:
                if (leaf[1] != null)
                {
                    Instantiate(leaf[1], lastLeafPosition, Quaternion.identity);
                    lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                    lastLeafPosition.y = (Random.Range(lastLeafPosition.y, maxY));
                }
                break;
            case 2:
                if (leaf[2] != null)
                {
                    Instantiate(leaf[2], lastLeafPosition, Quaternion.identity);
                    lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                    lastLeafPosition.y = (Random.Range(lastLeafPosition.y, maxY));
                }
                break;
            case 3:
                if (leaf[0] != null)
                {
                    Instantiate(leaf[3], lastLeafPosition, Quaternion.identity);
                    lastLeafPosition.x = (Random.Range(lastLeafPosition.x + leaf[0].GetComponent<Renderer>().bounds.size.x, lastLeafPosition.x * 1.6f));
                    lastLeafPosition.y = (Random.Range(lastLeafPosition.y, maxY));
                }
                break;
        }
       
    }
    public void PowerUps()
    {
        switch (Random.Range(0, 8))
        {
            case 0:
                if(powerUp!=null)
                Instantiate(powerUp, new Vector3(15.0f, 1.0f, 23.0f), Quaternion.identity);
                break;
        }
    }
   
}
