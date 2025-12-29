using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCartScript : MonoBehaviour
{
    public GameObject Cutscene;
        
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody;
        if ((rb != null) &&(collision.isTrigger == false))
        {
            Player player = rb.GetComponent<Player>();
            if (player != null)
            {
                Cutscene.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}