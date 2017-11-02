using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_On_Touch : MonoBehaviour
{

    public GameObject Planet;

    public float rotSpeed;

	// Update is called once per frame
	void Update ()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            if (Input.touchCount > 0)
            {
                RaycastHit hitMe = new RaycastHit();
                bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).deltaPosition), out hitMe);

                if (hit)
                {
                    if (hitMe.transform.gameObject.name == "Left")
                    {
                        Planet.transform.Rotate(Vector3.up, -rotSpeed);
                    }
                    else if (hitMe.transform.gameObject.name == "Right")
                    {
                        Planet.transform.Rotate(Vector3.up, rotSpeed);
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
                    if (hitMe.transform.gameObject.name == "Left")
                    {
                        Planet.transform.Rotate(Vector3.up, -rotSpeed);
                    }
                    else if (hitMe.transform.gameObject.name == "Right")
                    {
                        Planet.transform.Rotate(Vector3.up, rotSpeed);
                    }

                }
            }
        }


    }
}
