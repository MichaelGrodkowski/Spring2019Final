using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float multiplier = 2f;
    public GameObject pickUpEffect;
    public float duration = 4f;
   // public float interval = 4f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }


    IEnumerator Pickup(Collider player)
    {
        Instantiate(pickUpEffect, transform.position, transform.rotation);

        Ryl_Jump speed = player.GetComponent<Ryl_Jump>();
        speed.moveSpeed *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        

        yield return new WaitForSeconds(duration);

        speed.moveSpeed /= multiplier;


        Destroy(gameObject);
    }
}

    

/* ublic float multiplier = 2f;
public GameObject pickUpEffect;
public float duration = 4f;
// public float interval = 4f;

void OnTriggerEnter(Collider other)
{
if (other.CompareTag("Player"))
{
StartCoroutine(Pickup(other));
}
}


IEnumerator Pickup(Collider player)
{
Instantiate(pickUpEffect, transform.position, transform.rotation);

MovingRigidBody speed = player.GetComponent<MovingRigidBody>();
speed.moveSpeed *= multiplier;

GetComponent<Animator>().enabled = false;
GetComponent<Collider>().enabled = false;
        

yield return new WaitForSeconds(duration);

speed.moveSpeed /= multiplier;


Destroy(gameObject);
}
}

*/
