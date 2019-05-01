﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawningobjects : MonoBehaviour
{

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	void Start()
	{
		Spawn();
	}

	void Spawn()
	{
		Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.Euler(0,0,0));
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}
}