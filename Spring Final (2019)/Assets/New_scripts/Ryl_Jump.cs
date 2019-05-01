using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ryl_Jump : MonoBehaviour
{
    public Rigidbody playerRb;
    public float jump;
    
    public float moveSpeed;
    private float moveInput;

    public int jumpCount;


    void Start ()
    {
        jumpCount = 1;
    }

    void Update ()
    {
        //JUMP
        if (!Input.GetKeyDown("space")) return;
        if (jumpCount > 2) return;

        jumpCount = jumpCount + 1;

        playerRb.AddForce(0, jump, 0, ForceMode.Impulse);
    }
    
    
    
    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        playerRb.velocity = new Vector2(moveInput * moveSpeed + 4, playerRb.velocity.y);

    }




//----------------------------------------------------------------------------------


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GroundTag"))
        {
            jumpCount = 1;
        }
    }

}
