using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanOnDes : MonoBehaviour
{
    public GameObject destroyEffect;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(destroyEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}