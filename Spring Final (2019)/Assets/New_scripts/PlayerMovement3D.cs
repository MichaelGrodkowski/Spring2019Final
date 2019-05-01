using System.Collections;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    private bool onGround = true;
    private bool canDoubleJump = false;
    public float horizontalmove = 100f;

   
    float moveHorizontal = Input.GetAxis ("Horizontal");
    float moveVertical = Input.GetAxis ("Vertical");
    
    
    
    
    
    void update()
    {
        
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        RaycastHit hit;
        Vector3 physicsCentre = this.transform.position +
                                this.GetComponent<CapsuleCollider>().center;
        Debug.DrawRay(physicsCentre, Vector3.down*1.5f, Color.red, 1);
        if (Physics.Raycast(physicsCentre, Vector3.down, out hit, 1.5f))
        {
            if (hit.transform.gameObject.tag !="Player")
        {
            onGround = true;
        }
    }
    else
    {
        onGround = false;
    }
    Debug.Log(onGround);

        if (Input.GetKeyDown("Jump") && !onGround && canDoubleJump)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
            canDoubleJump = false;
        }    
        else if (Input.GetKeyDown("Jump") && onGround )
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
            canDoubleJump = true;
        }


    if (Input.GetKeyDown("Jump"))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        }
    }
}