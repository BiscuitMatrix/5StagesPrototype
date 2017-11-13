using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_SpawnLevel_BA : MonoBehaviour {

    public GameObject[] leaf;
    // Use this for initialization
    void Start () {
       
      Instantiate(leaf[0], new Vector3(5.0f,1.0f,23.0f), Quaternion.identity);
        Instantiate(leaf[1], new Vector3(11.0f, 1.0f, 23.0f), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
