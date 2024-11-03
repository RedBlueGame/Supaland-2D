using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject EnemyPrephab;
    public float Cooldown;
    public int ChildCount;
    public float Distance;

    private PlayerHealth _playerHealth;
    private float _timer;



    private void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {

        float distance;
        distance = Vector2.Distance(_playerHealth.transform.position,transform.position);




        _timer -= Time.deltaTime;

        if  ((_timer < 0) && (transform.childCount < ChildCount) && (distance >Distance))
        {
            Instantiate(EnemyPrephab, transform.position, transform.rotation, transform);
            _timer = Cooldown;
        }
    }

}
