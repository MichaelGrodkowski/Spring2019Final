using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedMove : MonoBehaviour
{
    public float Gravity = 1;
    private CharacterController controller;
    private Vector3 position;
    public float MoveSpeed = 5;
    
    private float jumpStart; 
    public float JumpValue = 20;
    public float JumpCount = 2;

    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.z = Input.GetAxis("Horizontal")*MoveSpeed*Time.deltaTime;
        
        if (JumpCount > 1 && Input.GetKeyDown(KeyCode.Space))
        {
            JumpCount--;
            position.y = JumpValue*Time.deltaTime;
        }

        if (controller.isGrounded)
        {
            JumpCount = jumpStart;
        } 
 
        position.y = Gravity * Time.deltaTime;
        controller.Move(position);

        

    }
}