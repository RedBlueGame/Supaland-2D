using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FlyingEnemy : MonoBehaviour
{
   
    public float Cooldown;
    public float Speed;
    public GameObject PointA;
    public GameObject PointB;
    public GameObject Target;
    public int Damage;

    private PlayerHealth _playerHealth;
    private float _timer;
    
    
    void Update()
    {

        _timer -= Time.deltaTime;

            _timer = Cooldown;
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
