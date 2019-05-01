using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 279);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
