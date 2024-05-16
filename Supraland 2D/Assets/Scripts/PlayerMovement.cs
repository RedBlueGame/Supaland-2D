using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        _jmuptime-=Time.deltaTime;
    }

    // Update is called once per frame
    public void FixedUpdate()
    { 

    Rigidbody2D rb = GetComponent<Rigidbody2D>();  
        Vector2 rbv = rb.velocity;
        rbv.x = Speed * Input.GetAxis("Horizontal");
        Anima.GetComponent<Animator>().SetFloat("Speed",Mathf.Abs( rbv.x));

        if (rbv.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        if (rbv.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if ((Input.GetAxis("Jump") > 0) & (JumpCount > 0) & (_jmuptime < 0 ))
        {
            rbv.y = JumpStrength;
            JumpCount--;
            _jmuptime = 0.7f;
        }
        rb.velocity = rbv; 

    }

    

    public float Speed;

    public float JumpStrength;

    public int JumpCount;
    public int MaxJumpCount;

    private float _jmuptime;

    public GameObject Anima;

}

