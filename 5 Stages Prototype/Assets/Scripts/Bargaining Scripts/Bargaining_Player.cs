using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bargaining_Player : MonoBehaviour {

    
    public float turnSpeed = 50f;
    public float moveSpeed = 5.0f;
    public Rigidbody rb;
    public Text boosterValue;
    private float booster;
    private bool thrust;
    private float direction;
    private bool left;
    private bool right;
    private float screenCenterX;



    // Use this for initialization
    void Start()
    {
       SetUp();
       

    }
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //}

    void Update()
    {
        Control();
        Die();
     

        boosterValue.text = "Boost:" + booster.ToString(); ;

    }

    void Control()
    {
         if (Input.GetKey(KeyCode.UpArrow))
        {
            thrust = true;
            right = true;
            MovePlayer();
        }

        if (thrust == false && booster < 100)
        {
            booster = booster + 1.5f;
        }
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                thrust = true;
                direction = Input.GetTouch(0).position.x;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                thrust = false;
            }

            if (thrust == true && booster > 0)
            {
               

                     GetDirection();
                     MovePlayer();
                    booster = booster - 1.2f;
                }
            }

        //}

    }
    void Die()
    {
        if (rb.position.y < -4.0f)
        {
            //TODO die and reset game
            SceneManager.LoadScene("Bargaining");
        }
    }

    void SetUp()
    {
        rb = GetComponent<Rigidbody>();
        booster = 100.0f;
        thrust = false;
        left = false;
        right = false;
        screenCenterX = Screen.width * 0.5f;
    }
   
    void GetDirection()
    {
        if(direction < screenCenterX)
        {
            right = false;
            left = true;
        }
        else if(direction> screenCenterX)
        {
            left = false;
            right = true;
        }
  
    }

    void MovePlayer()
    {
        if(left == true)
        {
            rb.velocity = new Vector3(-2.3f, 3.3f, 0f);
        }
        else if(right == true)
        {
            rb.velocity = new Vector3(2.3f, 3.3f, 0f);
        }

    }
}

