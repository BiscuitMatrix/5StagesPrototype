using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bargaining_Player : MonoBehaviour {

    
    public float turnSpeed = 50f;
    public float moveSpeed = 5.0f;
    public Rigidbody rb;
    float StartTime = 0;
    float RealTime = 0;
    int CountTime = 0;
    private float booster;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        booster = 110.0f;
       

    }
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //}

    void Update()
    {
        if(booster<110 && (Input.GetTouch(0).phase != TouchPhase.Stationary))
        {
            booster = booster + 2.5f;
        }
        //Touch myTouch = Input.GetTouch(0);

        //Touch[] myTouches = Input.touches;
        //for (int i = 0; i < Input.touchCount; i++)
        //{
        //    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        //}

        if (Input.touchCount > 0)
        {
            //if (Input.GetTouch(0).phase == TouchPhase.Began)
            //{
            //    StartTime = Time.time;
            //    CountTime = 1;
            //}

            if (Input.GetTouch(0).phase == TouchPhase.Stationary&& booster>0)
               // if (Input.GetKey(KeyCode.UpArrow))
                {
                    //RealTime = Time.time - StartTime;
                    //CountTime = 0;

                    // transform.Translate(Vector3.right * (RealTime * 20) * Time.deltaTime);
                    //  GetComponent<Rigidbody>().velocity = new Vector3(40, 50) * 100 * 50;
                    rb.velocity = new Vector3(3.9f, 4.3f, 0f);
                booster = booster - 0.4f;
                }

            }

        if(rb.position.y < -4.0f)
        {
            //TODO die and reset game
            SceneManager.LoadScene("Bargaining");
        }
        

    }




   
}

