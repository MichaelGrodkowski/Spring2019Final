using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_on_col : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}