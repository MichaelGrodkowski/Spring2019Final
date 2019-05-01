using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    public float moveSpeed = 3.0f;
    public GameObject character;
    public GameObject player;

    
    void Start()
    {
       // character = GetComponent<GameObject>();
        player = GameObject.Find("Player");
    }

    
    
    void Update()
    {
//code for looking to player
     character.transform.rotation = Quaternion.Slerp(character.transform.rotation,
      Quaternion.LookRotation(player.transform.position - character.transform.position), 3 * Time.deltaTime);

     
  
//code for following the player
        character.transform.position += character.transform.forward * moveSpeed * Time.deltaTime;
    }
}