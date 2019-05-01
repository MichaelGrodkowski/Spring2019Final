using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
[RequiredComponent(typeof(PlayerPhysics))]
public class PlayerController : MonoBehaviour
{
    public float gravity = 20f;
    public float speed = 8;
    public float accelleration = 12;

    private float currentSpeed;
    private float targetSpeed;
    private Vector3 amountToMove;

    private PlayerPhysics playerPhysics;
    
   
    void Start()
    {
        playerPhysics = GetComponent<playerPhysics>();
    }

 
    void Update()
    {
        targetSpeed = Input.GetAxisRaw("Horizontal") * speed;
        currentSpeed = IncrementTowards(currentSpeed, targetSpeed, accelleration);

        amountToMove = new Vector3(2 + currentSpeed, 0);
        playerPhysics.Move(amountToMove * Time.deltaTime);
    }
    private float IncrementTowards(float n, float target, float a)
    
}
*/