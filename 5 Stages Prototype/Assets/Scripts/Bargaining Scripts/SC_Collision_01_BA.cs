using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Collision_01_BA : MonoBehaviour {

    public SC_Score_BA scoring;
    public SC_SpawnLevel_BA spawn;
    private GameObject lastHit;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator OnCollisionEnter(Collision col)
    {

       // scoring.getName(col.gameObject.name);
        switch (col.gameObject.name)
        {
            
            case "SM_leaf_01_BA(Clone)":

                if (col.gameObject != null && col.gameObject != lastHit)
                {
                    lastHit = col.gameObject;
                    scoring.ScoreUpdate();
                    spawn.UpdateLevel();
                    yield return new WaitForSeconds(1.5f);
                    col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                    col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    yield return new WaitForSeconds(2);
                    Destroy(col.gameObject);
                    //to do - destroy after off screen
                }
                break;

            case "SM_leaf_02_BA(Clone)":

                if (col.gameObject != null && col.gameObject != lastHit)
                {
                    lastHit = col.gameObject;
                    scoring.ScoreUpdate();
                    spawn.UpdateLevel();
                    yield return new WaitForSeconds(1.5f);
                    col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                    col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    yield return new WaitForSeconds(2);
                    Destroy(col.gameObject);
                    //to do - destroy after off screen
                }
                break;

            case "SM_leaf_03_BA(Clone)":

                if (col.gameObject != null && col.gameObject != lastHit)
                {
                    lastHit = col.gameObject;
                    scoring.ScoreUpdate();
                    spawn.UpdateLevel();
                    yield return new WaitForSeconds(1.5f);
                    col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                    col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    yield return new WaitForSeconds(2);
                    Destroy(col.gameObject);
                    //to do - destroy after off screen
                }
                break;

            case "SM_leaf_04_BA(Clone)":

                if (col.gameObject != null && col.gameObject != lastHit)
                {
                    lastHit = col.gameObject;
                    scoring.ScoreUpdate();
                    spawn.UpdateLevel();
                    yield return new WaitForSeconds(1.5f);
                    col.gameObject.GetComponent<Rigidbody>().useGravity = true;
                    col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    yield return new WaitForSeconds(2);
                    Destroy(col.gameObject);
                    //to do - destroy after off screen
                }
                break;

            case "Sphere(Clone)":

                if (col.gameObject != null && col.gameObject != lastHit)
                {
                    lastHit = col.gameObject;
                    scoring.ScoreUpdate();
                    Destroy(col.gameObject);
                    spawn.PowerUps();
                    //to do - destroy after off screen
                }
                break;
        }
    }
}
