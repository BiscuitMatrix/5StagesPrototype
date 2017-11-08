using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bargaining_Level : MonoBehaviour {

    public GameObject[] planes;
    // Use this for initialization
    void Start () {

          for(int i = 0; i<4; i++)
        {
            planes.CreatePrimitive(PrimitiveType.Plane);
            
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
}
