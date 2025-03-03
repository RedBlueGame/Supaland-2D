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

        int floorCount = Physics2D.OverlapCollider(GrondCheck,Filter, Cols);
        int wallCount = Physics2D.OverlapCollider(WallCheck, Filter, Cols);
        if ((floorCount == 0) || (wallCount > 0))
        {
            Vector3 Scale = transform.localScale; 
            Scale.x *= -1;
            transform.localScale = Scale;
            Speed *= -1;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth player;
        if (collision.rigidbody != null)
        {


            player = collision.rigidbody.GetComponent<PlayerHealth>();

            if (player != null)
            {
                player.TakeDamage(Damage);
            }
        }
    }


    public int Damage;
    public float Speed;
    public Collider2D GrondCheck;
    public Collider2D WallCheck;
    public List<Collider2D> Cols;
    public ContactFilter2D Filter;
}
