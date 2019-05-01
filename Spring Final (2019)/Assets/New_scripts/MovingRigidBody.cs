using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRigidBody : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody theRB;
    public float jumpForce;

    private bool onGround = true;
    private bool canDoubleJump = false;

 

 

    void Start()
    {
        theRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y,
            Input.GetAxis("Vertical") * moveSpeed);

   if (Input.GetButtonDown("Jump"))
        {
         theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
           


        }
    }
}



