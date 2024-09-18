using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedStore : MonoBehaviour
{
    // Start is called before the first frame update
    public int Prise;

    public GameObject PriseText;
    public int UpgradeCount;
    public Wallet _wallet;

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
        if ((_wallet != null) && Input.GetKeyDown(KeyCode.E) && (UpgradeCount >0))
        {
            if (_wallet.Coins >= Prise)
            {
                _wallet.Coins -= Prise;
                _wallet.GetComponent<PlayerMovement>().Speed *=2 ;
                Prise = Prise * 2;
                UpgradeCount = UpgradeCount -1 ; 
            }
        }

        if (UpgradeCount > 0)
        {
            PriseText.GetComponent<TextMeshProUGUI>().text = "Press E<br>X2 Speed<br>" + Prise.ToString() + " Coins";
        }
        else
        {
            PriseText.GetComponent<TextMeshProUGUI>().text = "You have bought all items!";
        }
    }
}
