using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemynornallogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 rbv = rb.velocity;
        rbv.x = Speed;
        rb.velocity = rbv;

        Collider2D[] results = new Collider2D[2];
        int count = Physics2D.OverlapCollider(GrondCheck, new ContactFilter2D(), results);

        if (count == 0)
        {
            Vector3 Scale = transform.localScale; 
            Scale.x *= -1;
            transform.localScale = Scale;
            Speed *= -1;
        }

    }
    public float Speed;
    public Collider2D GrondCheck;
}
