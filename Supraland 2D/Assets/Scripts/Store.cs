using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

    public Wallet _wallet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

        if (wallet != null)
        {
            _wallet = wallet;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Wallet wallet = collision.attachedRigidbody.GetComponent<Wallet>();

        if (wallet != null)
        {
            _wallet = null;
        }
    }



    void Start()
    {
        
    }

    

    void Update()
    {
      if ((_wallet != null) && Input.GetKeyDown(KeyCode.E))
        {
            if (_wallet.Coins >= 10)
            {
                _wallet.Coins -= 10;
                _wallet.GetComponent<PlayerMovement>().MaxJumpCount += 1;
            }
        }
    }
}
