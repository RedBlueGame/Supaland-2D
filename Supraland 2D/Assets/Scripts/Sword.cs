using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Collider2D SwordCollider;
    public List<Collider2D> Enemies;
    public ContactFilter2D Filter;
    public int Damage;
    public float Cooldown;

    private float _timer;

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && ( _timer < 0))
        {
             Physics2D.OverlapCollider(SwordCollider, Filter, Enemies);
            foreach (Collider2D enemy in Enemies) 
            {
                enemy.attachedRigidbody.GetComponent<EnemyHealth>().TakeDamage(Damage);
            }
            _timer = Cooldown;
        }
    }
}
