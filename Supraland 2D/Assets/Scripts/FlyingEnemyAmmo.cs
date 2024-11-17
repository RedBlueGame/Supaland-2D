using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FlyingEnemyAmmo : MonoBehaviour
{
    public int Damage;
    public float Speed;
    public Vector3 Target;

    private GameObject _player;

    void Start()
    {
        _player = FindObjectOfType<PlayerHealth>().gameObject;
        Target = _player.transform.position;
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, Time.deltaTime * Speed);
        if (transform.position == Target)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb;
        rb = collision.rigidbody;
        if (rb != null)
        {

            PlayerHealth playerHealth;
            playerHealth = rb.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(Damage);
                Destroy(gameObject);
            }
        }

        if (rb == null)
        {
            Destroy(gameObject);
        }
    }

   
}
