using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public GameObject HealthBar;
    public GameObject HealthText; 
    public GameObject LivesText;
    public GameObject LastChecpoint;
    public int Health; 
    public int MaxHealth;
    public int Lives;

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Lives--;
            if (Lives <= 0)
            {
              SceneManager.LoadScene("SampleScene");   
            }
            else
            {
               transform.position = LastChecpoint.transform.position;
                Health = MaxHealth;
                PlayerDebuffs playerDebuffs = gameObject.GetComponent<PlayerDebuffs>();
                if (playerDebuffs != null)
                {
                    playerDebuffs.ClearDebuffs();
                }
            }
        }
    }

    public void AddHealth(int amount)
    {
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    private void Update()
    {
        HealthBar.GetComponent<Slider>().value = Health;
        HealthBar.GetComponent<Slider>().maxValue = MaxHealth;
        HealthText.GetComponent<TextMeshProUGUI>().text = Health + "/" + MaxHealth;
        LivesText.GetComponent<TextMeshProUGUI>().text = Lives.ToString();

    }

}
