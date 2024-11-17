using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardEnemyAmmo : MonoBehaviour
{
    public int Damage;
    public float Speed;
    public Vector3 Target;

    private GameObject _player;

    void Start()
    {
        _player = FindObjectOfType<PlayerHealth>().gameObject;
    }

   
    void Update()
    {
        Target = _player.transform.position;
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
