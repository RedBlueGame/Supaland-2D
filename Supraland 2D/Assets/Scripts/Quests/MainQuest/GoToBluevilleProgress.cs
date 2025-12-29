using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBluevilleProgress : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;
        if ((rb != null) && (collision.isTrigger == false))
        {
            PlayerHealth playerHealth = rb.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                GoToBlueville quest = FindObjectOfType<GoToBlueville>();

                if (quest != null)
                {
                    quest.FinishQuest();
                }
            }
        }
    }
}