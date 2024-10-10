using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float Speed;
    public int Damage;
   
    void Update()
    {
        transform.Translate(Time.deltaTime*Speed,0,0); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb;
        rb = collision.attachedRigidbody;
        if (rb != null)
        {
            EnemyHealth enemyHealth;
            enemyHealth = rb.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(Damage);
            }

            PlayerHealth playerHealth;
            playerHealth = rb.GetComponent<PlayerHealth>();
            if (playerHealth == null)
            {
                Destroy(gameObject);
            }
        }
        
          if (rb == null)
        {
            Destroy(gameObject);
        }
            
         
    }
}
