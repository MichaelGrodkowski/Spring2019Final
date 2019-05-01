using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_player : MonoBehaviour
{
    public GameObject objToDestroy;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(objToDestroy);

    }

}