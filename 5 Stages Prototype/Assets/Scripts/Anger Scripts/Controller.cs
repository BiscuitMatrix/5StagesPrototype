using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    // Initialise variables
    public float speed = 1000;
    public Rigidbody rb;
    public float bonusSpeed = 10;
    public float velocity;

    GameObject wall;
    private WallBreakScript wallBreakScript;
    private Vector3 lastVelocity;


    void Start()
    {
        // Get the player's RigidBody
        rb = GetComponent<Rigidbody>();

        // Lock the screen orientation to portrait
        Screen.orientation = ScreenOrientation.Portrait;
    }

    void Main()
    {
        // Prevent phone from sleeping
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }

    private void Update()
    {
        // Exit condition for mobile
        if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

        velocity = rb.velocity.sqrMagnitude;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Calculate movement vector
        Vector3 movement = Vector3.zero;
        movement.x = Input.acceleration.x;
        //movement.z = Input.acceleration.y;

        
        // Clamp the movement vector
        if (movement.sqrMagnitude > 1)
        {
            movement.Normalize();
        }
        
        // Move the player based on the tilt
        movement *= Time.deltaTime;

        rb.AddForce(movement*speed, ForceMode.Acceleration);
        rb.AddForce(new Vector3(0, 0, 1), ForceMode.Force);

        lastVelocity = rb.velocity;
    }

    // Handle Collisions
    void OnCollisionEnter(Collision col)
    {
        // If colliding with a Breakable object
        if(col.gameObject.tag == "Breakable")
        {
            wall = col.gameObject;
            wallBreakScript = wall.GetComponent<WallBreakScript>();
            // Compare the player's speed against the break speed required for the wall
            if (lastVelocity.magnitude > wallBreakScript.break_Speed)
            {
                // If player is fast enough, destroy the wall
                Destroy(col.gameObject);
                rb.AddForce(new Vector3(lastVelocity.x * bonusSpeed, 0.0f, lastVelocity.z * bonusSpeed), ForceMode.Impulse);
            }
            else
            {
                SceneManager.LoadScene("main");
            }
        }
        if (col.gameObject.tag == "Goal")
        {
            if (lastVelocity.magnitude > wallBreakScript.break_Speed)
            {
                SceneManager.LoadScene("main");
            }
        }
    }

}
