using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FlyingEnemy : MonoBehaviour
{
    public int Damage;
    public float Cooldown;
    public int ChildCount;
    public float Distance;
    public float Speed;
    public GameObject PointA;
    public GameObject PointB;
    public GameObject Target;

    private PlayerHealth _playerHealth;
    private float _timer;
    void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }
    
    void Update()
    {
        float distance;
        distance = Vector2.Distance(_playerHealth.transform.position, transform.position);




        _timer -= Time.deltaTime;

        if ((_timer < 0) && (transform.childCount < ChildCount) && (distance > Distance))
        {
            Instantiate(EnemyPrephab, transform.position, transform.rotation, transform);
            _timer = Cooldown;
        }
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * Speed);

        if (transform.position == PointA.transform.position)
        {
            if (_isActive)
            {
                Target = PointB;
            }
        }

        if (transform.position == PointB.transform.position)
        {
            Target = PointA;
        }

    }

}
