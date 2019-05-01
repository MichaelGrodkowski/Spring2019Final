using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharacters : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 position;
    public float Gravity = 9.81f;
    public float JumpValue = 20;
    public float JumpCount = 2;
    private float jumpStart;
    
    void Start()
    {
        jumpStart = JumpCount;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
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