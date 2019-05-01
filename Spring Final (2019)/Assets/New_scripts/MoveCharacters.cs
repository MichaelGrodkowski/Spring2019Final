using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacters : MonoBehaviour
{
    public float Gravity = 1;
    private CharacterController controller;
    private Vector3 position;
    public float MoveSpeed = 5;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void Update()
    {
        position.z = Input.GetAxis("Horizontal")*MoveSpeed*Time.deltaTime;
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space)) ;
            position.y += 100;

        }
        
        position.y = Gravity * Time.deltaTime;
        controller.Move(position);

    }
}