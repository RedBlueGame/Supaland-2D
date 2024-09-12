using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MJumpStore : MonoBehaviour
{
    public int Prise;
    public int UpgradeCount;
    public GameObject PriseText;


    private Wallet _wallet;
    private bool _isActive;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

        if (_isActive && wallet != null)
        {
            _wallet = wallet;
            PriseText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

        if (_isActive && wallet != null)
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
      if (_isActive && (_wallet != null) && Input.GetKeyDown(KeyCode.E) && (UpgradeCount > 0))
        {
            if (_wallet.Coins >=Prise)
            {
                _wallet.Coins -= Prise;
                _wallet.GetComponent<PlayerMovement>().MaxJumpCount += 1;
                _wallet.GetComponent<PlayerMovement>().JumpCount = _wallet.GetComponent<PlayerMovement>().MaxJumpCount;
                Prise = Prise * 3;
                UpgradeCount = UpgradeCount - 1;
            }
        }

      if(UpgradeCount > 0)
        {
            PriseText.GetComponent<TextMeshProUGUI>().text = "Press E<br> +1 max jump<br>" + Prise.ToString() + " Coins";
        }
        else
        {
            PriseText.GetComponent<TextMeshProUGUI>().text = "You have bought all items!";
        }
    }





}
