using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCNRB : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public CharacterController controller;
    public float gravityScale;
    
    
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f,
            Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        moveDirection.y = moveDirection.y + Physics.gravity.y * gravityScale;
        controller.Move(moveDirection * Time.deltaTime); 
    }
}