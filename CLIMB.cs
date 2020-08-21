using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLIMB : MonoBehaviour
{
    public float speed;
    Rigidbody RB;
    Animator Anim;
    bool IsClimb = false;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixUpdate()
    {
        if (IsClimb == true && Input.GetKey(KeyCode.LeftControl))
        {
            Anim.SetFloat("Run", 1f);
            RB.velocity = RB.velocity + Vector3.up * speed * Time.deltaTime;
        }

    }
    private void OnCollisionStay(Collision obj)
    {
        if (obj.gameObject.tag == "Cliff")
        {
            if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
            {
                print(222);
                Anim.SetFloat("Run", Mathf.Abs(Input.GetAxis("Vertical")));
                RB.velocity = new Vector3(0, Input.GetAxis("Vertical") * speed, 0);
            }
        }
    }
   
}
