//MetaScript was written by Alan Guild
//The MetaScript is for the Main Menu / Meta Game and contains all the controls and actions for the scene.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaScript : MonoBehaviour
{
    public GameObject Planet;
    public float rotSpeed;

    private Transform cameraTransform;
    public Transform lookShop;
    public Transform lookMain;

    private const float cameraRotSpeed = 0.1f;

    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))        //change to Input.TouchCount > 0;
        {
            RaycastHit HitDestination = new RaycastHit();

            bool Hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out HitDestination);      //change Input.mousePosition to Input.GetTouch(0).deltaPosition

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
                        rotateToShop();
                        break;

                    case "Back":
                        rotateToMain();
                        break;
               }
           }
       }

    void rotateToShop()
    {
       
    }

    void rotateToMain()
    {
        //if (lookMain != null)
        //{
        //    while (cameraTransform.rotation != lookMain.rotation)
        //    {
        //        cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, lookMain.rotation, cameraRotSpeed * Time.deltaTime);
        //    }
        //}
    }
    
}

