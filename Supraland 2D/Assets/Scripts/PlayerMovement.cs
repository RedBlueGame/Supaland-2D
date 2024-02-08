using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        Speed = Input.GetAxis("Horizontal");
    }
    public float Speed;


}
