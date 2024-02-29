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

        if ((Input.GetAxis("Jump") > 0) & (JumpCount > 0) & (_jmuptime < 0 ))
        {
            rbv.y = JumpStrength;
            JumpCount--;
            _jmuptime = 0.7f;
        }
        rb.velocity = rbv; 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JumpCount = MaxJumpCount;
    }

    public float Speed;

    public float JumpStrength;

    public int JumpCount;
    public int MaxJumpCount;

    private float _jmuptime;
}

