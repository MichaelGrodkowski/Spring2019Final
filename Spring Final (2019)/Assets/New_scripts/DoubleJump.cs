using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour

{
    private CharacterController controller;
    private Vector3 position;
    private float jumpStart;

    public float MoveSpeed = 5;
    public float Gravity = 1;
    public float JumpValue = 20;
    
    public float JumpCount = 2;


    // Start is called before the first frame update
    void Start()
    {
        jumpStart = JumpCount;
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {

        position.x = Input.GetAxis("Horizontal") + MoveSpeed * Time.deltaTime;

        if (JumpCount > 1 && Input.GetKeyDown(KeyCode.Space))
        {
            JumpCount--;
            position.y = JumpValue*Time.deltaTime;
        }

        if (controller.isGrounded)
        {
            JumpCount = jumpStart;
        }

        position.y -= Gravity * Time.deltaTime;
        controller.Move(position);
    }
}







































/*
{
    private CharacterController controller;
    private Vector3 position;
    private float jumpStart;

    public float MoveSpeed = 5;
    public float Gravity = 1;
    public float JumpValue = 20;
    public float JumpCount = 2;


    // Start is called before the first frame update
    void Start()
    {
        jumpStart = JumpCount;
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
 
    {

        position.x = Input.GetAxis("Horizontal") + MoveSpeed * Time.deltaTime;

        if (JumpCount > 1 && Input.GetKeyDown(KeyCode.Space))
        {
            JumpCount--;
            position.y = JumpValue*Time.deltaTime;
        }

        if (controller.isGrounded)
        {
            JumpCount = jumpStart;
        }

        position.y -= Gravity * Time.deltaTime;
        controller.Move(position);
    }
}

























/*{
    public float moveSpeed;
    private float jumpSpeed = 2;
    public Rigidbody rigidBody;
    private bool onGround = true;

    private const int MAX_JUMP = 2;
    private int currentJump = 0;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
 
  if (Input.GetKeyDown("Jump") && onGround || MAX_JUMP > currentJump)
 
            {
                rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
                onGround = false;
                currentJump++;
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            onGround = true;
            currentJump = 0;
        }
    }
*/