using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningPowerScript : MonoBehaviour {

    public float speedMult = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();
            col.GetComponent<Rigidbody>().AddForce(new Vector3(rb.velocity.x * speedMult, 0.0f, rb.velocity.z * speedMult), ForceMode.Impulse);
        }
    }
}
