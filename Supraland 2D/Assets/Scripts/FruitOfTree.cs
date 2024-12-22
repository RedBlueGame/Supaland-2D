using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitOfTree : MonoBehaviour
{
    public int HealthPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger != false)
        {
            PlayerHealth playerHealth = collision.attachedRigidbody.GetComponent<PlayerHealth>();

            if ((playerHealth != null) && (playerHealth.Health < playerHealth.MaxHealth))
            {
                Destroy(gameObject);
                playerHealth.AddHealth(HealthPoints);
            }
        }

    }
}
