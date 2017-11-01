using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Level_On_Touch : MonoBehaviour
{

    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            if (Input.touchCount > 0)
            {
                RaycastHit hitMe = new RaycastHit();
                bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).deltaPosition), out hitMe);

                if (hit)
                {
                    Debug.Log("Hit" + hitMe.transform.gameObject.name);

                    if(hitMe.transform.gameObject.name == "Spring")
                    {
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Denial", LoadSceneMode.Additive);       //load Denial Level         
                    }
                    else if (hitMe.transform.gameObject.name == "Summer")
                    {
                                //load Anger scene
                    }
                    else if(hitMe.transform.gameObject.name == "Autumn")
                    {
                                //load Bargaining scene     
                    }
                    else if(hitMe.transform.gameObject.name == "Winter")
                    {
                                //load Depression scene
                    }
                    else if (hitMe.transform.gameObject.name == "Hot Air Balloon")
                    {
                                // Load acceptance scene
                    }
                    else if(hitMe.transform.gameObject.name == "Shop")
                    {
                                //rotate camera to shop OR Load shop scene
                    }

                    
                }
            }
        }
        else if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit hitMe = new RaycastHit();
                bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitMe);

                if (hit)
                {
                    Debug.Log("Hit" + hitMe.transform.gameObject.name);

                    if (hitMe.transform.gameObject.name == "Spring")
                    {
                        SceneManager.UnloadSceneAsync("MetaGame");
                        SceneManager.LoadScene("Denial", LoadSceneMode.Additive);       //load Denial Level         
                    }
                    else if (hitMe.transform.gameObject.name == "Summer")
                    {
                        //load Anger scene
                    }
                    else if (hitMe.transform.gameObject.name == "Autumn")
                    {
                        //load Bargaining scene     
                    }
                    else if (hitMe.transform.gameObject.name == "Winter")
                    {
                        //load Depression scene
                    }
                    else if (hitMe.transform.gameObject.name == "Hot Air Balloon")
                    {
                        // Load acceptance scene
                    }
                    else if (hitMe.transform.gameObject.name == "Shop")
                    {
                        //rotate camera to shop OR Load shop scene
                    }
                }
            }
        }

    }
}