using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDest : MonoBehaviour
{
    // Start is called before the first frame update

 public float interval = 4f;   
    
    void Start()
    {
        Destroy(gameObject, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
