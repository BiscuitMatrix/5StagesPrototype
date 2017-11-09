using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningPowerPlacer : MonoBehaviour {

    public GameObject ground;
    public GameObject player;
    public GameObject powerup;
    public float minPlaceDist;
    public float maxPlaceDist;
    public int strikeTimer;
    public int strikeLength;

    private Vector3 powerupPos;
    private int counter = 0;

    void RandomisePos()
    {
        Renderer groundRenderer = ground.GetComponent<Renderer>();
        powerupPos = new Vector3(Random.Range((ground.transform.position.x - (groundRenderer.bounds.size.x/2)), (ground.transform.position.x + (groundRenderer.bounds.size.x / 2))),
                                 ground.transform.position.y + 1.0f,
                                 Random.Range(player.transform.position.z + minPlaceDist, (player.transform.position.z + maxPlaceDist)));
    }

    // Use this for initialization
    void Start () {
        powerup.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(counter == strikeTimer * 60)
        {
            RandomisePos();
            powerup.transform.position = powerupPos;
            powerup.SetActive(true);
        }
        if(counter == ((strikeTimer + strikeLength) * 60))
        {
            powerup.SetActive(false);
            counter = 0;
        }
        counter++;
	}
}
