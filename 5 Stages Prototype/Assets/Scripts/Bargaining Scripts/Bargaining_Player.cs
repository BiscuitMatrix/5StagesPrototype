using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bargaining_Player : MonoBehaviour {

    
    public float turnSpeed = 50f;
    public float moveSpeed = 5.0f;
    public Rigidbody rb;
    float StartTime = 0;
    float RealTime = 0;
    int CountTime = 0;
    public Text boosterValue;
    private float booster;
    private bool thrust;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        booster = 100.0f;
        thrust = false;
       

    }
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //}

    void Update()
    {
        if(thrust == false && booster<100)
        {
            booster = booster + 1.5f;
        }
        //Touch myTouch = Input.GetTouch(0);

        //Touch[] myTouches = Input.touches;
        //for (int i = 0; i < Input.touchCount; i++)
        //{
        //    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        //}

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                thrust = true;
            }
            if(Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                thrust = false;
            }

            if (thrust == true && booster>0)
               // if (Input.GetKey(KeyCode.UpArrow))
                {
                    //RealTime = Time.time - StartTime;
                    //CountTime = 0;

                    // transform.Translate(Vector3.right * (RealTime * 20) * Time.deltaTime);
                    //  GetComponent<Rigidbody>().velocity = new Vector3(40, 50) * 100 * 50;
                    rb.velocity = new Vector3(2.7f, 4.3f, 0f);
                booster = booster - 1.2f;
                }

            }

        if(rb.position.y < -4.0f)
        {
            //TODO die and reset game
            SceneManager.LoadScene("Bargaining");
        }

        boosterValue.text = booster.ToString(); ;

    }




   
}

