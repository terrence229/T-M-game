using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    
    public CharacterController controller;
    /*  animatie in speler 
    public Animator animator;
    public float InputX;
    public float InputY;
    public float InputZ;
    */

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        //animator = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x +transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded)
            {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            }

        velocity.y += gravity * Time.deltaTime;


        // animatie in speler proces 
        
        controller.Move(velocity * Time.deltaTime);
        /*
        Debug.Log(Input.GetAxis("Jump"));
        InputY = Input.GetAxis("Jump");
        animator.SetFloat("Input Y", InputY);

        //InputZ = Input.GetAxis("Jump");
        //animator.SetFloat("Input Z", InputZ);

        InputX = Input.GetAxis("Vertical");
        animator.SetFloat("Input X", InputX);
    
        */
    }
}
