using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicQuestProgress : MonoBehaviour
{
    private bool _isCollected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;
        if ((rb != null) &&(collision.isTrigger == false) && (_isCollected == false))
        {
            Player player = rb.GetComponent<Player>();
            if (player != null)
            {
                MecanicQuest quest = FindObjectOfType<MecanicQuest>();

                if (quest != null)
                {
                    quest.AddProgress();
                    Destroy(gameObject);
                    _isCollected = true;
                }
            }
        }
    }

    void Start()
    {
        gameObject.SetActive(false);
        _isCollected = false;
    }
}
