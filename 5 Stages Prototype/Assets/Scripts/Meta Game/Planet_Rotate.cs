﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Rotate : MonoBehaviour
{
    public float speed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
	}
}