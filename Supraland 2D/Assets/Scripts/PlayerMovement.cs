using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        _jmuptime-=Time.deltaTime;
    }

    // Update is called once per frame
    public void FixedUpdate()
    { 

        Vector2 rbv = _rb.velocity;
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

        _rb.velocity = rbv; 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_rb.IsTouching(ContactFilter))
        {
            JumpCount = MaxJumpCount;
        }
        
    }

    public float Speed;

    public float JumpStrength;

    public int JumpCount;
    public int MaxJumpCount;

    private float _jmuptime;

    public GameObject Anima;
    public ContactFilter2D ContactFilter;

    private Rigidbody2D _rb;


}
