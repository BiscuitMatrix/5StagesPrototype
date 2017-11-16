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
    private bool up;
    private bool right;



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
     

        boosterValue.text = booster.ToString(); ;

    }

    void Control()
    {
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
                // if (Input.GetKey(KeyCode.UpArrow))

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
        up = false;
        left = false;
        right = false;
    }
   
    void GetDirection()
    {
        if(direction < rb.position.x)
        {
            left = true;
        }
        else if(direction> rb.position.x)
        {
            right = true;
        }
        else
        {
            up = true;
        }
    }

    void MovePlayer()
    {
        if(left == true)
        {
            rb.velocity = new Vector3(-2.7f, 4.3f, 0f);
        }
        else if(right == true)
        {
            rb.velocity = new Vector3(2.7f, 4.3f, 0f);
        }
        else if(up == true)
        {
            rb.velocity = new Vector3(0.0f, 4.3f, 0f);
        }
    }
}

