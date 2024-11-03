using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MucGiffinItem : MonoBehaviour
{
    
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;
        if (rb != null)
        {
            WeaponSelector weaponSelector = rb.GetComponent<WeaponSelector>();
            if (weaponSelector != null)
            {
                weaponSelector.HasMucGiffin = true;
                Destroy(gameObject);
               
                
            }
        }
    }
}
