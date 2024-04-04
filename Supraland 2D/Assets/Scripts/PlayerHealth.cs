using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject HealtBar;
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
        HealtBar.GetComponent<Slider>().value = Health;
        HealtBar.GetComponent<Slider>().maxValue = MaxHealth;
    }

}
