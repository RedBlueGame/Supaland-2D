using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ForceBean : MonoBehaviour
{
    public float Cooldown;
    public GameObject LightPanel;
    public float RaycastLenght;
    public ContactFilter2D Filter;
    public int Damage;

    private float _timer;
    private List<RaycastHit2D> _enemies = new();
    
    void Update()
    {

        _timer -= Time.deltaTime;

        if (Input.GetMouseButton(0) && (_timer < 0))
        {          
            _timer = Cooldown;
            Physics2D.Raycast(transform.position, Vector2.right * transform.lossyScale.x ,Filter, _enemies, RaycastLenght);
            foreach (RaycastHit2D enemy in _enemies)
            {
                enemy.rigidbody.GetComponent<EnemyHealth>().TakeDamage(Damage);
            }
        }

        LightPanel.GetComponent<Image>().fillAmount = Mathf.InverseLerp(Cooldown,0,_timer);

    }
}
