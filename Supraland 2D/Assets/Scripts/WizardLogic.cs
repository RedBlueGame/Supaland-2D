using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardLogic : MonoBehaviour
{
    public int Damage;
    public float Speed;
    public float Cooldown;
    public float MaxDistance;
    public Collider2D GrondCheck;
    public Collider2D WallCheck;
    public List<Collider2D> Cols;
    public ContactFilter2D Filter;

    private float _timer;
    private PlayerHealth _playerHealth;

     void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }
    void Update()
    {
        _timer -= Time.deltaTime;
        _timer = Cooldown;

        float distance;
        distance = Vector2.Distance(_playerHealth.transform.position, transform.position);
    }

    public void FixedUpdate()
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 rbv = rb.velocity;
        rbv.x = Speed;
        rb.velocity = rbv;

        int floorCount = Physics2D.OverlapCollider(GrondCheck, Filter, Cols);
        int wallCount = Physics2D.OverlapCollider(WallCheck, Filter, Cols);
        if ((floorCount == 0) || (wallCount > 0))
        {
            Vector3 Scale = transform.localScale;
            Scale.x *= -1;
            transform.localScale = Scale;
            Speed *= -1;
        }

    }
}
