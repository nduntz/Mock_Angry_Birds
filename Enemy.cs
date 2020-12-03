using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float health = 4f;
    public GameObject deathEffect;
    public static int EnemiesAlive = 0;

    void Start()
    {
        EnemiesAlive++;
    }
    
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.relativeVelocity.magnitude> health)
        {
            Die();
            Destroy(gameObject);
        }

        
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        EnemiesAlive--;
        if (EnemiesAlive <= 0)
            //Debug.Log("Level Won!");
        Destroy(gameObject);
    }

}

