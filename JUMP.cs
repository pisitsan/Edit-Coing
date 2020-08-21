using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour
{
    Rigidbody RB;
    Animator Anim;
    public float jumpheight;
    public bool CharacterOnTheGround = true;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        //If Press Spacebar character jump
        if (Input.GetAxis("Jump") != 0 && CharacterOnTheGround)
        {
            Anim.SetBool("Jump", true);
            RB.AddForce(new Vector3(0, jumpheight, 0), ForceMode.Impulse);
            CharacterOnTheGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Cliff" || collision.gameObject.tag == "Block")
        {
            CharacterOnTheGround = true;
            Anim.SetBool("Jump", false);
        }

    }
}