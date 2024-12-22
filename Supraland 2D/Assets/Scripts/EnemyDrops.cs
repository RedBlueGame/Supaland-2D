using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrops : MonoBehaviour
{
    public GameObject Prefab;
    public float ChanceDrop;
    private void OnDestroy()
    {
       
        float roll;
        roll = Random.Range(0f,1f);
        EnemyHealth health;
        health = GetComponent<EnemyHealth>();

        if ((roll < ChanceDrop) && (health.Health <= 0))
        {
           GameObject go = Instantiate(Prefab,transform.position + Vector3.up,transform.rotation);
           Destroy(go,10f);
        }
    }
}
