using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public AudioClip DeathSFX;

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            FindObjectOfType<SFX>().PlayClip(DeathSFX);
            Destroy(gameObject);
        }
    }
}
