using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Level_On_Touch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
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

                    if(hitMe.transform.gameObject.name == "Planet/Spring")
                    {
                        SceneManager.LoadScene("Denial", LoadSceneMode.Additive);                    
                    }
                    else if (hitMe.transform.gameObject.name == "Planet/Summer")
                    {
                        
                    }
                    else if(hitMe.transform.gameObject.name == "Planet/Autumn")
                    {
                       
                    }
                    else if(hitMe.transform.gameObject.name == "Planet/Winter")
                    {
                        
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

                    if (hitMe.transform.gameObject.name == "Planet/Spring")
                    {
                        SceneManager.LoadScene("Denial", LoadSceneMode.Additive);
                    }
                    else if (hitMe.transform.gameObject.name == "Planet/Summer")
                    {

                    }
                    else if (hitMe.transform.gameObject.name == "Planet/Autumn")
                    {

                    }
                    else if (hitMe.transform.gameObject.name == "Planet/Winter")
                    {

                    }
                }
            }
        }

    }
}