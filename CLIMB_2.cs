using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLIMB_2 : MonoBehaviour
{
    public float speed;
    Rigidbody RB;
    Animator Anim;

    

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixUpdate()
    {
        float Climb = Input.GetAxis("Vertical");
    }
    private void OnCollisionStay(Collision obj)
    {
        if (obj.gameObject.tag == "Cliff" || obj.gameObject.tag == "Block")
        {
            if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
            {
                print(222);
                Anim.SetFloat("Climb", Mathf.Abs(Input.GetAxis("Vertical")));
                RB.velocity = new Vector3(0, Input.GetAxis("Vertical") * speed, 0);
            }
        }
    }

    private void OnCollisionExit(Collision obj)
    {
        if (obj.gameObject.tag == "Cliff" || obj.gameObject.tag == "Block")
        {
            Anim.SetFloat("Climb", 0);
        }
    }
}
