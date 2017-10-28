using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_Touch_Rotate : MonoBehaviour
{
    public float rotSpeed;

    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

                if (touchDeltaPosition.y < Screen.height / 3)
                {
                    if (touchDeltaPosition.x > Screen.width / 2)
                    {
                        transform.Rotate(Vector3.up, -rotSpeed);
                    }
                    else
                    {
                        transform.Rotate(Vector3.up, rotSpeed);
                    }
                }

            }
        }
        else if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mousePosition = Input.mousePosition;

                if (mousePosition.y < Screen.height / 3)
                {
                    if (mousePosition.x > Screen.width / 2)
                    {
                        transform.Rotate(Vector3.up, -rotSpeed);
                    }
                    else
                    {
                        transform.Rotate(Vector3.up, rotSpeed);
                    }
                }

            }
        }
    }
}
