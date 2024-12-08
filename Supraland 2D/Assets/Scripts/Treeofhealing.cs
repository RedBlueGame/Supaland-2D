using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Treeofhealing : MonoBehaviour
{
    public int Prise;
    public GameObject PriseText;


    private Wallet _wallet;
    private PlayerHealth _playerHealth;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;

        Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

        PlayerHealth playerHealth = collision.attachedRigidbody.GetComponent<PlayerHealth>();

        if ((wallet != null) && (playerHealth != null))
        {
            _wallet = wallet;
            _playerHealth = playerHealth;
            PriseText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

        PlayerHealth playerHealth = collision.attachedRigidbody.GetComponent<PlayerHealth>();

        if ((wallet != null) && (playerHealth != null))
        {
            _wallet = null;
            _playerHealth = null;
            PriseText.SetActive(false);
        }
    }



    void Start()
    {

    }



    void Update()
    {
        
        if ((_wallet != null) && Input.GetKeyDown(KeyCode.E)  &&(_playerHealth != null))
        {
            if (_wallet.Coins >= Prise)
            {
                _wallet.Coins -= Prise;
                _playerHealth.Health += 10;
            }
        }
            PriseText.GetComponent<TextMeshProUGUI>().text = "Press E<br> +10 Health Points<br>";
        
    }
}
