using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//imports unity stuff
public class FirstPerson : MonoBehaviour
{
    float horizontalSpeed = 300f;
    float verticalSpeed = 300f;
    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Locks cursor to the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame

    //We will use this to create the first person controller by modifying the player view via the mouse,
    //Modified from a youtube tutorial. All comments are my own. 
    //Credit Brackeys: https://www.youtube.com/watch?v=_QajrabyTJc
    void Update()
    {
        //Take our default sensitivity and the user mouse input, and add the Frame rate to make sure it doesnt change depending on FPS.
        float mouseX = horizontalSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
        float mouseY = verticalSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;

        xRotation -= mouseY;
        //Locks user from overextending view. 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Set up a transform so whatever object is attached will rotate up when the user gives mouse input up. 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        
    }
}