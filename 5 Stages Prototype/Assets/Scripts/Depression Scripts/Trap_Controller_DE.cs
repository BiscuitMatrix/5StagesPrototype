﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Controller_DE : MonoBehaviour
{

    // This solution needs improved or a workaround if max_trap_layers is made higher than 5 - J
    public GameObject Trap_1_Layer, Trap_2_Layers, Trap_3_Layers, Trap_4_Layers, Trap_5_Layers;

    public Transform Generate_Point;
    public float division_distance;

    private float trap_layers;
    public int min_trap_layers;
    public int max_trap_layers;

    // Use this for initialization
    void Start()
    {

    }

    void Update () {

        Generate_Traps();
       
	}

    void Generate_Traps()
    {
        // Constantly generate traps limited by minimum divisions up to a max distance ahead of player - J
        if (transform.position.x < Generate_Point.position.x)
        {
            // Set a new location for the next trap - relative to Trap_Generator_DE object - J
            transform.position = new Vector3(transform.position.x + division_distance, transform.position.y, transform.position.z);

            // Pick how many layers it will have and instantiate it - J
            switch (Random.Range(min_trap_layers, max_trap_layers))
            {
                case 1:
                    Instantiate(Trap_1_Layer, transform.position, transform.rotation);
                    break;

                case 2:
                    Instantiate(Trap_2_Layers, transform.position, transform.rotation);
                    break;

                case 3:
                    Instantiate(Trap_3_Layers, transform.position, transform.rotation);
                    break;

                case 4:
                    Instantiate(Trap_4_Layers, transform.position, transform.rotation);
                    break;

                case 5:
                    Instantiate(Trap_5_Layers, transform.position, transform.rotation);
                    break;
            }
        }
    }
}
