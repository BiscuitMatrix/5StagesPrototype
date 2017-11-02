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
                        SceneManager.UnloadScene("MetaGame");
                       // StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Denial", LoadSceneMode.Additive);       //load Denial Level         
                    }
                    else if (hitMe.transform.gameObject.name == "Summer")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Anger", LoadSceneMode.Additive);        //load Anger scene
                    }
                    else if(hitMe.transform.gameObject.name == "Autumn")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Bargaining", LoadSceneMode.Additive);        //load Bargaining scene     
                    }
                    else if(hitMe.transform.gameObject.name == "Winter")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Depression", LoadSceneMode.Additive);        //load Depression scene
                    }
                    else if (hitMe.transform.gameObject.name == "Hot Air Balloon")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Acceptance", LoadSceneMode.Additive);         // Load acceptance scene
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
                        SceneManager.UnloadScene("MetaGame");
                        SceneManager.LoadScene("Denial", LoadSceneMode.Additive);       //load Denial Level     
                    }
                    else if (hitMe.transform.gameObject.name == "Summer")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Anger", LoadSceneMode.Additive);        //load Anger scene
                    }
                    else if (hitMe.transform.gameObject.name == "Autumn")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Bargaining", LoadSceneMode.Additive);        //load Bargaining scene     
                    }
                    else if (hitMe.transform.gameObject.name == "Winter")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Depression", LoadSceneMode.Additive);        //load Depression scene
                    }
                    else if (hitMe.transform.gameObject.name == "Hot Air Balloon")
                    {
                        StartCoroutine(UnloadAsync());
                        SceneManager.LoadScene("Acceptance", LoadSceneMode.Additive);         // Load acceptance scene
                    }
                    else if (hitMe.transform.gameObject.name == "Shop")
                    {
                        //rotate camera to shop OR Load shop scene
                    }
                }
            }
        }

    }

    IEnumerator UnloadAsync()
    {
        AsyncOperation Unload = SceneManager.UnloadSceneAsync("MetaGame");
        while(!Unload.isDone)
        {
            yield return null;
        }
    }
}