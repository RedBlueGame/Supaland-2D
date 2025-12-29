using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MucGuffinUlta : MonoBehaviour
{
    public float Speed;
    public int Damage;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Time.deltaTime * Speed, 0f, 0f, Space.World);
        transform.Rotate( Time.deltaTime * Speed * 0f, 0f, 40f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Rigidbody2D rb;
        rb = collision.attachedRigidbody;
        if ((rb != null) && (collision.isTrigger == false))
        {
            EnemyHealth enemyHealth;
            enemyHealth = rb.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(1);
            }
 
        }
    }
}
