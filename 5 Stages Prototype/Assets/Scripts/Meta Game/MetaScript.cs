using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaScript : MonoBehaviour
{
    public GameObject Planet;
    public float rotSpeed;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit HitDestination = new RaycastHit();

            bool Hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out HitDestination);

            switch (HitDestination.transform.gameObject.name)
               {
                    case "Left":
                        Planet.transform.Rotate(Vector3.up, -rotSpeed);     //roatate planet left
                        break;
                    

                    case "Right":
                        Planet.transform.Rotate(Vector3.up, rotSpeed);      //rotate planet right
                        break;
        
                    case "Denial":
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Denial");       //load Denial Level      
                        break;

                    case "Anger":
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Anger");        //load Anger scene
                        break;

                    case "Bargaining":
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Bargaining");        //load Bargaining scene   
                        break;

                    case "Depression":
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Depression");        //load Depression scene
                        break;

                    case "Acceptance":
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Acceptance");         // Load acceptance scene
                        break;

                    case "Shop":
                       
                        break;

                }
            }
        }

    
}

