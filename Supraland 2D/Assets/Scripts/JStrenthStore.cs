using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

   
    public class JStrenthStore : MonoBehaviour
    {
        public int Prise;
        public int UpgradeCount;
        public GameObject PriseText;


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
            if ((_wallet != null) && Input.GetKeyDown(KeyCode.E) && (UpgradeCount > 0))
            {
                if (_wallet.Coins >= Prise)
                {
                    _wallet.Coins -= Prise;
                    _wallet.GetComponent<PlayerMovement>().JumpStrength += 5;
                    Prise = Prise * 2;
                    UpgradeCount = UpgradeCount - 1;
                }
            }

            if (UpgradeCount > 0)
            {
                PriseText.GetComponent<TextMeshProUGUI>().text = "Press E<br> +5 points of the JumpStrenth <br>" + Prise.ToString() + " Coins";
            }
            else
            {
                PriseText.GetComponent<TextMeshProUGUI>().text = "You have bought all items!";
            }
        }


 


    }

