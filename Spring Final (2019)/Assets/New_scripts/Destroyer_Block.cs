using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_Block : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
   

        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}