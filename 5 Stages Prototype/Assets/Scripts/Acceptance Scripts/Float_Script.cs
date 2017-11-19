 //Acceptance_Script authored by Alan Guild
// This script applys the physics to the Hot Air Balloon and also works with the state of the stage.

//To Do
//- 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Float_Script : MonoBehaviour
{
    public Rigidbody hotAirBalloon;
    public Transform balloonTransform;
    public Transform planetTransform;
    public ParticleSystem engine;

    private bool isBoost = false;       //bool for if a boost is currently being applied
    private bool isGrounded = true;     //bool to say if Balloon has Taken off
    private bool fingerOnScreen = false;        //bool to say if there is currently a touch
    private bool isCoRoutineActive = false;     //bool to check if co-routines are active

    public int noOfCanisters;

    //UI Variables

    public Text cans;       //text to show the amount of fuel cannisters the playere has left to you
    public Text scoreText;
    private int score = 0;

    //Progress Bar
    public Slider balloonProgress;      //slider to show the progress the balloon has made from the earth to the new planet
    private Slider progress;
    float percentComplete;

    //power bar variables
    public Slider PowerSlider;
    private Slider powerBar;
    private float fuelLoss = 2.0f;
    private float boostOnTouch;


    void Start()
    {
        //Progress Bar
        progress = balloonProgress;
        progress.minValue = 0f;
        progress.maxValue = 100f;
        progress.value = 0f;

        //Power Bar
        powerBar = PowerSlider;     

        powerBar.minValue = 0f;
        powerBar.maxValue = 10f;
        powerBar.value = 10.0f;
    }

	// Update is called once per frame
	private void Update ()
    {
        //UI
        
        cans.text = "Cans: " + noOfCanisters.ToString();
        scoreText.text = score.ToString();
        progressBar();

        if (hotAirBalloon.velocity.y > 0.0)
        {
            Score();
        }

        if (isGrounded  && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)      //takeoff
        {
            fingerOnScreen = true;
            noOfCanisters += 1;
            TakeOff();
        }

        //reduce fuel & apply constant speed
        if (!isGrounded )
        {
            PowerBar();
        }

    }

    void progressBar()
    {
        percentComplete = (100 / planetTransform.position.y) * hotAirBalloon.position.y;
        Debug.Log(percentComplete);
        balloonProgress.value = percentComplete;
    }

    void PowerBar()
    {
        ConstantSpeed();        //gives balloon constant speed

        //fuel loss
        powerBar.value -= fuelLoss * Time.deltaTime;
        if (fingerOnScreen == false)
        {
            fingerOnScreen = true;
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)       //if user touch and noOfCanisters is not empty
            {
                if (noOfCanisters > 0 && powerBar.value != 0.0f)
                {
                    isCoRoutineActive = true;
                    StartCoroutine(ApplyBoost());
                }
                
            }
            else if (noOfCanisters == 0 || powerBar.value == 0.0f)
            {
                isCoRoutineActive = true;
                StartCoroutine(Empty());
            }
        }

        if (Input.touchCount == 0 )
        {
            fingerOnScreen = false;
        }
        
    }

    void Boosts(int boostCase)
    {
        switch (boostCase)
        {

            case 0:     //Bad Boost
                isBoost = true;
                hotAirBalloon.AddForce(0.0f, 1.5f, 0.0f, ForceMode.Impulse);
                noOfCanisters--;
                isBoost = false;

                Debug.Log("Bad");
                break;

            case 1:     //Ok Boost
                isBoost = true;
                hotAirBalloon.AddForce(0.0f, 2.5f, 0.0f, ForceMode.Impulse);
                score += 250;
                noOfCanisters--;
                isBoost = false;

                Debug.Log("Ok");
                break;

            case 2:     //Perfect Boost
                isBoost = true;
                hotAirBalloon.AddForce(0.0f, 5.0f, 0.0f, ForceMode.Impulse);
                score += 500;
                noOfCanisters--;
                isBoost = false;

                Debug.Log("Perfect");
                break;

            case 3:     //out of fuel
                isBoost = true;
                noOfCanisters = 0;
                hotAirBalloon.velocity =new Vector3( 0.0f, (-1.0f * Time.deltaTime), 0.0f);
                isBoost = false;

                Debug.Log("Out Of Fuel");
                break;

            case 4:
                //translate hot air balloon to new planet slowly and land
                break;

        }
    }

    IEnumerator ApplyBoost()
    {
        boostOnTouch = powerBar.value;
        powerBar.value = 10.0f;

        if(boostOnTouch >= 5.0f)
        {
            Boosts(0);
        }
        else if(boostOnTouch < 5.0f && boostOnTouch >= 2.0f)
        {
            Boosts(1);
        }
        else if(boostOnTouch < 2.0f && boostOnTouch > 0.0f)
        {
            Boosts(2);
        }

        yield return null;

        isCoRoutineActive = false;
    }

    IEnumerator Empty()
    {
        powerBar.value = 0.0f;
        engine.Stop();

        if(balloonTransform.position.y < planetTransform.position.y + 5.0f)
        {
            Boosts(3);
        }
        else if(balloonTransform.position.y >= planetTransform.position.y + 5.0f)
        {
            Boosts(4);
        }


        yield return null;

        isCoRoutineActive = false;
    }

    void TakeOff()
    {
        if (isGrounded)     //initial constant take off speed
        {
            isGrounded = false;
            hotAirBalloon.AddForce(0.0f, 1.0f, 0.0f, ForceMode.Impulse);
        }
        fingerOnScreen = false;
    }

    void ConstantSpeed()
    {
        if (hotAirBalloon.velocity.y < 1.0 && noOfCanisters > 0 && isGrounded == false)
        {
            hotAirBalloon.AddForce(0.0f, 2.0f, 0.0f, ForceMode.Impulse);
        }
    }

    void Score()
    {
        score += (int) hotAirBalloon.position.y;
        
    }

    void reachedPlanet()        //reached the new reality
    {

    }

    

}
