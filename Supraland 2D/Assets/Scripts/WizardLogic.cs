using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WizardLogic : MonoBehaviour
{
    public int Damage;
    public float Speed;
    public float Cooldown;
    public float AttackRange;
    public GameObject Patron;
    public Collider2D GrondCheck;
    public Collider2D WallCheck;
    public List<Collider2D> Cols;
    public ContactFilter2D Filter;

    private float _timer;
    private PlayerHealth _playerHealth;
    private List<RaycastHit2D> _walls = new();

    void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }
    void Update()
    {
        _timer -= Time.deltaTime;

        float distance;
        distance = Vector2.Distance(_playerHealth.transform.position, transform.position);

        Vector2 rayDir;
        rayDir = _playerHealth.transform.position - transform.position;
        int walls = Physics2D.Raycast(_playerHealth.transform.position, rayDir, Filter, _walls, AttackRange);

        if ((walls == 0) && (distance < AttackRange) && (_timer < 0))
        {
            Instantiate(Patron, transform.position, transform.rotation);
            _timer = Cooldown;
        }
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
