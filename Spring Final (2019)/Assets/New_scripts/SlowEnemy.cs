using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowEnemy : MonoBehaviour
{
    public float multiplier = 2f;
    public float duration = 4f;
   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            StartCoroutine(Slow(other));
        }
    }


    IEnumerator Slow(Collider enemy)
    {

        EnemyFollow moveSpeed = enemy.GetComponent<EnemyFollow>();
        moveSpeed.moveSpeed -= multiplier;


        yield return new WaitForSeconds(duration);

        moveSpeed.moveSpeed /= multiplier;


      
    }
}

