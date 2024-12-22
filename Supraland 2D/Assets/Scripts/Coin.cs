using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger != false)
        {
            Wallet player = collision.attachedRigidbody.GetComponent<Wallet>();

            if (player != null)
            {
                Destroy(gameObject);

                player.Coins += 1;
            }
        }
        
    }



}
