using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;

public class Missile : MonoBehaviour {
	
	
	public float speed;
	Vector3 startPOS;
	public float speedMin = 3f;
	public float speedMax = 7f;

	void Start()
	{
		startPOS = transform.position;
	}

	void Update()
	{
		transform.Translate((new Vector3(-2, 0, 0)) * speed * Random.Range(speedMin, speedMax) * Time.deltaTime);
       

	}
    
}
// Quaternion.Euler(x,y,z) 