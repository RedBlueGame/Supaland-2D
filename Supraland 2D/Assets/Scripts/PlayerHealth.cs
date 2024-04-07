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
    public int Health; 
    public int MaxHealth; 

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }


    }
    private void Update()
    {
        HealthBar.GetComponent<Slider>().value = Health;
        HealthBar.GetComponent<Slider>().maxValue = MaxHealth;
        HealthText.GetComponent<TextMeshProUGUI>().text = Health + "/" + MaxHealth;
    }

}
