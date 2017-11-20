using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_DE : MonoBehaviour
{

    public float Jump_Vertical_Force;
    public float Jump_Horizontal_Force;
    public float Ray_Hit_Distance;
    public float Movement_Speed;


    public Rigidbody Player_Rigidbody;
    private bool Is_Grounded;
    private bool IsTrapped = false;
    private int Input_Count = 0;
    private int Current_Trap_Level;

    void Start()
    {
        // assign components to our private Rigidbody in-object
        Player_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Update IsGrounded bool per frame
        Check_Grounded();

        // Check for input - change to trap-event-success or trap-event-fail once implemented
        Check_Input();
        Trap_Outcome_Check();
        Move_Right();

    }

    void Trap_Outcome_Check()
    {
        // replace with trap end flag - add Fail_Response
        if (IsTrapped == true && Input_Count >= Current_Trap_Level)
        {
            Success_Response();
        }
    }

    void Success_Response()
    {
            // Break out of trap
            Jump_Out();

            // Wait & animate during jump-out event  
            // yield return new WaitUntil(() => Is_Grounded == true);

            // if vertical velocity >= 0
            // animate upwards jump animation
            // else if vertical velocity < 0 
            // animate falling
    }

    // Called when entering trap collision box 
    public void Get_Trapped(int Trap_Count)
    {
        IsTrapped = true;
        Current_Trap_Level = Trap_Count;
    }

    // Called when leaving trap collision box
    public void Get_Free()
    {
        IsTrapped = false;
        Input_Count = 0;
        Current_Trap_Level = 0;
    }

    private void Check_Input()
    {
        if (IsTrapped == true)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Ended)
                {
                    Input_Count += 1;
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                Input_Count += 1;
            }
        }
    }

    void Check_Grounded()
    {
        if (Is_Grounded)
        {
            Ray_Hit_Distance = 0.35f;
        }
        else
        {
            Ray_Hit_Distance = 0.15f;
        }


        if (Physics.Raycast (transform.position - new Vector3(0, 0.45f, 0), -transform.up, Ray_Hit_Distance))
        {
            Is_Grounded = true;
        }
        else
        {
            Is_Grounded = false;
        }
    }


    void Jump_Out()
    {
        if (Is_Grounded == true && IsTrapped == true)
        {
            Player_Rigidbody.AddForce(new Vector3(Jump_Horizontal_Force, Jump_Vertical_Force, 0));
            //Is_Grounded = false;
        }
    }

    void Move_Right()
    {
        if (IsTrapped == false)
        {
            Vector3 Move_Vect = new Vector3(1, 0, 0) * Movement_Speed * Time.deltaTime;
            Player_Rigidbody.MovePosition(transform.position + Move_Vect);
        }
    }
}
