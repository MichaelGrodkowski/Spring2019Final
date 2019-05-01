using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_dest : MonoBehaviour
{
  
    public GameObject destroyEffect;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
         
            Destroy(other.gameObject);
        }

    }
}