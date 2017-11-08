using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bargaining_Player : MonoBehaviour {

    public float turnSpeed = 50f;
    public float moveSpeed = 5.0f;
    public Rigidbody rb;
    float StartTime = 0;
    float RealTime = 0;
    int CountTime = 0;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

       
    }
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //}

    void Update()
    {

        //Touch myTouch = Input.GetTouch(0);

        //Touch[] myTouches = Input.touches;
        //for (int i = 0; i < Input.touchCount; i++)
        //{
        //    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        //}

      //  if (Input.touchCount > 0)
       // {
            //if (Input.GetTouch(0).phase == TouchPhase.Began)
            //{
            //    StartTime = Time.time;
            //    CountTime = 1;
            //}

           // if (Input.GetTouch(0).phase == TouchPhase.Ended)
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    RealTime = Time.time - StartTime;
                    CountTime = 0;

                    // transform.Translate(Vector3.right * (RealTime * 20) * Time.deltaTime);
                    //  GetComponent<Rigidbody>().velocity = new Vector3(40, 50) * 100 * 50;
                    rb.velocity = new Vector3(3f, 4f, 0f);
                }

            //}

        

    }




    IEnumerator OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Plane1")
        {
            // Destroy(col.gameObject);
            // StartCoroutine(waitThreeSeconds(col));
            yield return new WaitForSeconds(3);
            col.gameObject.GetComponent<Rigidbody>().useGravity = true;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        if (col.gameObject.name == "Plane2")
        {
            // Destroy(col.gameObject);
            // StartCoroutine(waitThreeSeconds(col));
            yield return new WaitForSeconds(3);
            col.gameObject.GetComponent<Rigidbody>().useGravity = true;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        if (col.gameObject.name == "Plane3")
        {
            // Destroy(col.gameObject);
            //StartCoroutine(waitThreeSeconds(col));
            yield return new WaitForSeconds(3);
            col.gameObject.GetComponent<Rigidbody>().useGravity = true;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}

