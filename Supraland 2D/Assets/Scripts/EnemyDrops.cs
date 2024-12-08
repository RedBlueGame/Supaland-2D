using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrops : MonoBehaviour
{
    public GameObject Prefab;
    private void OnDestroy()
    {
       
        float roll;
        roll = Random.Range(0f,1f);
        EnemyHealth health;
        health = GetComponent<EnemyHealth>();

        if ((roll < 0.5f) && (health.Health <= 0))
        {
            Instantiate(Prefab,transform.position + Vector3.up,transform.rotation);
        }
    }
}
