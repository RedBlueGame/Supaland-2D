using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position , Target. transform.position, Time.deltaTime * Speed); 

       if(transform.position == PointA.transform.position)
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>() != null)
        {
            collision.gameObject.transform.parent = transform;
            _isActive = true;
        }

    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>() != null)
        {
            collision.gameObject.transform.parent = null;
            _isActive = false;
        }

    }

    public GameObject PointA ;
    public GameObject PointB ;
    public GameObject Target ;
    public float Speed ;

    private bool _isActive;
   
}
