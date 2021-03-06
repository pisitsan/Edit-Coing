﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROL : MonoBehaviour
{
    public float speed;
    Rigidbody RB;
    Animator Anim;
    bool facingRight;

   
   
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        
        float move = Input.GetAxis("Horizontal");
      
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            
            Anim.SetFloat("Run", Mathf.Abs(Input.GetAxis("Horizontal")));
            RB.velocity = new Vector3(0, RB.velocity.y, Input.GetAxis("Horizontal") * speed);
        }

        if (move > 0 && !facingRight) Flip();
        else if (move < 0 && facingRight) Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.z *= -1;
        transform.localScale = theScale;
    }
}
