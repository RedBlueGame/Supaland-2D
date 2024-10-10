using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MucGiffin : MonoBehaviour
{
    public GameObject AmmoPrephab;
    public float Cooldown;
    public float AmmoSpeed;
    public int AmmoDamage;

    private float _timer;

    
    void Start()
    {

    }

    
    void Update()
    {
        _timer -= Time.deltaTime;

        if (Input.GetMouseButton(0) && (_timer < 0))
        {
            GameObject fly;
            fly = Instantiate(AmmoPrephab,transform.position,transform.rotation);
            Destroy(fly,15);
            fly.GetComponent<Ammo>().Speed = AmmoSpeed * transform.lossyScale.x;
            fly.GetComponent<Ammo>().Damage = AmmoDamage;

            _timer = Cooldown;
        }

        


    }
}
