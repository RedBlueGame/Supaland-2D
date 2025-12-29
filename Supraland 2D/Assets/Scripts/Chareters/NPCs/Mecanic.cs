using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanic : MonoBehaviour
{
    public GameObject Quest;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;
        if ((rb != null) && (collision .isTrigger == false))
        {
            WeaponSelector weaponSelector = rb.GetComponent<WeaponSelector>();
            if (weaponSelector != null)
            {
               MecanicQuest mecanicQuest = Quest.GetComponent<MecanicQuest>();
                if (mecanicQuest.IsAllScrapCollected() == true)
                {
                    mecanicQuest.FinishQuest();
                    if (weaponSelector.MucGiffin == true)
                    {
                        weaponSelector.UnlockMucGugginUlt();
                    }

                }
                else
                {
                    Quest.SetActive(true);
                }
            }
        }
    }


    void Update()
    {
        
    }
}
