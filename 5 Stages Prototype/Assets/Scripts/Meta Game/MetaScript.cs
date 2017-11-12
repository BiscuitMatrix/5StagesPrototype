//MetaScript was written by Alan Guild
//The MetaScript is for the Main Menu / Meta Game and contains all the controls and actions for the scene.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//TO DO
//- remove Desktop Code
//-implement in-shop code

public class MetaScript : MonoBehaviour
{
    public GameObject Planet;
    public float rotSpeed;

    private Transform cameraTransform;
    public Transform lookShop;
    public Transform lookMain;

    private bool isCoRoutineActive = false;
    Coroutine lastRoutine = null;

    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld) //Check if Handheld device
        {
            if (Input.touchCount > 0)        //check for a touch
            {
                RaycastHit HitDestination = new RaycastHit();

                bool Hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).deltaPosition), out HitDestination);      //get touch position for raycast

                switch (HitDestination.transform.gameObject.name)       //switch statement
                {
                    case "Left":
                        Planet.transform.Rotate(Vector3.up, -rotSpeed);     //roatate planet left
                        break;


                    case "Right":
                        Planet.transform.Rotate(Vector3.up, rotSpeed);      //rotate planet right
                        break;

                    case "Denial":
                        SceneManager.LoadScene("Denial");       //load Denial Level      
                        break;

                    case "Anger":
                        SceneManager.LoadScene("Anger");        //load Anger scene
                        break;

                    case "Bargaining":
                        SceneManager.LoadScene("Bargaining");        //load Bargaining scene   
                        break;

                    case "Depression":
                        SceneManager.LoadScene("Depression");        //load Depression scene
                        break;

                    case "Acceptance":
                        SceneManager.LoadScene("Acceptance");         // Load acceptance scene
                        break;

                    case "Shop":
                        isCoRoutineActive = true;
                        lastRoutine = StartCoroutine(rotateToShop());
                        break;

                    case "Back":
                        isCoRoutineActive = true;
                        lastRoutine = StartCoroutine(rotateToMain());
                        break;
                }
            }
        }
        else if (SystemInfo.deviceType == DeviceType.Desktop)       //REMOVE AFTER TESTING ON DESKTOP
        {
            if (Input.GetMouseButton(0))        //change to Input.TouchCount > 0;
            {
                RaycastHit HitDestination = new RaycastHit();

                bool Hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out HitDestination);      //change Input.mousePosition to Input.GetTouch(0).deltaPosition

                if (Hit)
                {
                    switch (HitDestination.transform.gameObject.name)       //switch statement
                    {
                        case "Left":
                            Planet.transform.Rotate(Vector3.up, -rotSpeed);     //roatate planet left
                            break;


                        case "Right":
                            Planet.transform.Rotate(Vector3.up, rotSpeed);      //rotate planet right
                            break;

                        case "Denial":
                            SceneManager.LoadScene("Denial");       //load Denial Level      
                            break;

                        case "Anger":
                            SceneManager.LoadScene("Anger");        //load Anger scene
                            break;

                        case "Bargaining":
                            SceneManager.LoadScene("Bargaining");        //load Bargaining scene   
                            break;

                        case "Depression":
                            SceneManager.LoadScene("Depression");        //load Depression scene
                            break;

                        case "Acceptance":
                            SceneManager.LoadScene("Acceptance");         // Load acceptance scene
                            break;

                        case "Shop":
                            if (!isCoRoutineActive)
                            {
                                isCoRoutineActive = true;
                                lastRoutine = StartCoroutine(rotateToShop());
                            }
                            break;

                        case "Back":
                            if (!isCoRoutineActive)
                            {
                                isCoRoutineActive = true;
                                lastRoutine = StartCoroutine(rotateToMain());
                            }
                            break;
                    }
                }
            }
        }
    }


    IEnumerator rotateToShop()
    {
        for (float i = 0.0f; i <= 1; i += Time.deltaTime / 2.0f)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, lookShop.rotation, i);
            yield return null;
        }
        isCoRoutineActive = false;
    }

    IEnumerator rotateToMain()
    {
        for (float i = 0.0f; i <= 1; i += Time.deltaTime / 2.0f)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, lookMain.rotation, i);
            yield return null;
        }
        isCoRoutineActive = false;
    }
    
}

