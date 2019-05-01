using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendJump : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private float moveInput;
    private bool isGrounded;

    public float jumpForce;

    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed + 4, rb.velocity.y);

    }
}

















/*
    void Update()
    {
              isGrounded = Physics.OverlapSphere(feetPos, checkRadius, whatIsGround);
       
               if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
               {
                   rb.velocity = Vector2.up * jumpForce;
               }
           }
             
       

    }
*/