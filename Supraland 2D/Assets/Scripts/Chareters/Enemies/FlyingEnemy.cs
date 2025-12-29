using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FlyingEnemy : MonoBehaviour
{
   
    public float Cooldown;
    public float Speed;
    public float AttackRange;
    public GameObject PointA;
    public GameObject PointB;
    public GameObject Target;
    public GameObject Bullet;
    public ContactFilter2D Filter;

    private PlayerHealth _playerHealth;
    private float _timer;
    private List<RaycastHit2D> _walls = new();

    void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        _timer -= Time.deltaTime;

        float distanse;
        distanse = Vector2.Distance(_playerHealth.transform.position, transform.position);

        Vector2 rayDir;
        rayDir = _playerHealth.transform.position - transform.position;
        int walls = Physics2D.Raycast(_playerHealth.transform.position, rayDir, Filter, _walls, AttackRange);

        if ((walls == 0) && (distanse < AttackRange) && (_timer < 0))
        {
            _timer = Cooldown;
            Instantiate(Bullet,transform.position,transform.rotation);
        }
    }

   

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * Speed);

        if (transform.position == PointA.transform.position)
        {
                Target = PointB;
        }

        if (transform.position == PointB.transform.position)
        {
            Target = PointA;
        }

    }

}
