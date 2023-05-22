using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;


    public Transform orientation;


    float xRotation;
    float yRotation;

    private void Start()
    {
        {
            
            cursor.lockstate = CursorLockMode.Locked;
            Cursor.visible = false;
            
        }

    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X")*Time.deltaTime* sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y")*Time.deltaTime* sensY;

        yRotation +=mouseX;
        xRotation -=mouseY;
        xRotation = mathf.Clamp(xRotation, -90f, 90f);

        // rotate cam and orientation
        transform.rotate = Quaternion.Euler(xRotation, yRotation,0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

}
