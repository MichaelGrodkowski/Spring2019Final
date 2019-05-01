using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    private Animator anim;
    
    
    void Start()
    {
        anim = GetComponent <Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)){
        anim.SetBool("IsRunning", true);
    }

            else 
            {
                anim.SetBool("IsRunning", false);
            }


            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetTrigger("jump");
            }
            
            
        }
    }

