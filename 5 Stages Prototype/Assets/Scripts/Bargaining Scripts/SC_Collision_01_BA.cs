using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Collision_01_BA : MonoBehaviour {

    public SC_Score_BA scoring;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator OnCollisionEnter(Collision col)
    {

        scoring.getName(col.gameObject.name);
        switch (col.gameObject.name)
        {

            case "SM_leaf_01_BA(Clone)":

                scoring.ScoreUpdate();
                yield return new WaitForSeconds(3);
                col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                //to do - destroy after off screen
                if (col.gameObject.GetComponent<Rigidbody>().position.y < -3.0f)
                    Destroy(col.gameObject);
                break;

            case "SM_leaf_02_BA(Clone)":

                scoring.ScoreUpdate();
                yield return new WaitForSeconds(3);
                col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                //to do - destroy after off screen
                if (col.gameObject.GetComponent<Rigidbody>().position.y < -3.0f)
                    Destroy(col.gameObject);
                break;

            case "Plane3":

                scoring.ScoreUpdate();
                yield return new WaitForSeconds(3);
                col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                //to do - destroy after off screen
                // Destroy(col.gameObject);
                break;
        }
    }
}
