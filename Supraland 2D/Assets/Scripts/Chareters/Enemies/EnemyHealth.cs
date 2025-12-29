using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public AudioClip DeathSFX;
    public GameObject HealthBar;

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            FindObjectOfType<SFX>().PlayClip(DeathSFX);
            Destroy(gameObject);
        }


        if (HealthBar != null)
        {
            float hp = Health;
            float maxHp = MaxHealth;
            HealthBar.GetComponent<Image>().fillAmount = hp/maxHp;
        }

    }

    private void Start()
    {
        Health = MaxHealth;
        TakeDamage(0);
    }

    private void Update()
    {
        if (HealthBar != null)
        {
            HealthBar.transform.localScale = transform.localScale;
        }
    }
}
