using UnityEngine;
using System.Collections;

public class ScoreUpdate_DN : MonoBehaviour
{
	private float score;
	public GameObject player;
	public GameObject UI;

	void Start ()
	{
		score = player.transform.position.x;
	}

	void Update ()
	{
		AddScore();
	}
		

	public void AddScore ()
	{
		score = player.transform.position.x;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		UI.GetComponent<TextAsset> = "Score: " + score;
	}
}