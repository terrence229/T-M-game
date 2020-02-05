using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public BoxCollider box;
    public CharacterController controller;
    static Animator animator;

    public float rotationspeed = 100.0f;
    public float speed = 10f;
    public float gravity = -20f;
    public float jumpHeight = 2f;

    //public Transform groundCheck;
    //public float groundDistance = 0.4f;
    //public LayerMask groundMask;
    //bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity, ForceMode.Acceleration);
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float translation = Input.GetAxis("Vertical")* speed;
        float rotation = Input.GetAxis("Horizontal") * rotationspeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        

        if (translation == 0)
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Idle", true);
            animator.SetBool("Running", false);
            speed = 10;
        }
        if (translation != 0 && speed == 10)
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Walking", true);
            //Debug.Log("1");
        }
        if (Input.GetKey(KeyCode.LeftShift) && translation != 0)
        {
            speed = 15;
            animator.SetBool("Walking", false);
            animator.SetBool("Running", true);
            //Debug.Log("2");
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) && translation != 0)
        {
            animator.SetBool("Running", false);
            
            animator.SetBool("Walking", true);
            speed = 10;
            //Debug.Log("3");
        }
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("IsJumping");
            
        }
    }
}
