using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PHealth : MonoBehaviour
{
    public int Prise;

    public GameObject PriseText;

    public int MaxHealth;

    private Wallet _wallet;

 
    
        
       

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

            if (wallet != null)
            {
                _wallet = wallet;
                PriseText.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

            if (wallet != null)
            {
                _wallet = null;
                PriseText.SetActive(false);
            }
        }



        void Start()
        {

        }



        void Update()
        {
            if ((_wallet != null) && Input.GetKeyDown(KeyCode.E))
            {
                if (_wallet.Coins >= Prise)
                {
                    _wallet.Coins -= Prise;
                    _wallet.GetComponent<PlayerHealth>().MaxHealth += 10;
                    Prise = Prise * 2;
                }
            }

            PriseText.GetComponent<TextMeshProUGUI>().text = "Press E<br>for max health<br>" + Prise.ToString() + " Coins";
        }
    
}
