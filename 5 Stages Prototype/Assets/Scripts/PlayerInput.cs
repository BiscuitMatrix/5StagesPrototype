using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Variable Declarations
    int constVel;

    // Function Declarations
    //void autoMove();
    //void input();


    // Use this for initialization
    void Start()
    {
        constVel = 2;
        //autoMove();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void autoMove()
    {
        //vel.x = constVel;
    }

    void input()
    {
        // Detect and remember input
        // How do you represent a swipe in code?
        // Take the current position
        // Take the past position
        // Compare

       // if (Input.GetTouch(0) == /* Swipe Left */)
       // {
            // Is there a path on the left?
            // If there is, move player to path on the left
            // If not, do nothing
      // }
       // else if ((Input.GetTouch(0) == /* Swipe Right */))
       // {
            // Is there a path on the right?
            // If there is, move player to path on the right
            // If not, do nothing
       // }
        
    } // End Input

}