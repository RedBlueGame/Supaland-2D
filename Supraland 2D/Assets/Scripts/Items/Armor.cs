using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    private bool _isCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;
        if ((rb != null) && (collision.isTrigger == false) && (_isCollected == false))
        {
            Player player = rb.GetComponent<Player>();
            if (player != null)
            {
                player.EquipArmor();
                Destroy(gameObject);
                PlayerHealth playerHealth = rb.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.BoostMaxHealth(3);
                }
            }
        }
    }
}
