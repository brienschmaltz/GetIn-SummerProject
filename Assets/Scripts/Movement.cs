using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple WASD movement in Unity using a character controller. 
public class Movement : MonoBehaviour 
{
    public CharacterController controller;
    public float movementSpeed = 5f;
    public float gravity = -9.821f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;


    //Modified from a youtube tutorial. All comments are my own. 
    //Credit Brackeys: https://www.youtube.com/watch?v=_QajrabyTJc   
    void Update()
    {   
        //Sphere is created undereath the object placed under the player. This sphere checks to see if there is ground, aka a floor. 
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }
        
        
        //
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //Move the player based on the x and z value
        Vector3 move = transform.right * x + transform.forward * z;
        //
        controller.Move(move * movementSpeed * Time.deltaTime);

        //Player gravity;
        //Delta y = 1/2 gravity * t^2
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


/*      if(Input.GetKey(KeyCode.W))
        {
            controller.Move(moveForward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(moveRight * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(moveLeft * movementSpeed * Time.deltaTime);
        }
        */
    }
}
