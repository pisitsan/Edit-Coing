using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULL : MonoBehaviour
{
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision obj)
    {
        if(obj.gameObject.tag == "Block")
        {
            if(Input.GetKey(KeyCode.LeftControl))
            {
                obj.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
                Anim.SetBool("Pullitem", true);
            }
            else
            {
                obj.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                Anim.SetBool("Pullitem", false);
            }
        }
    }
    private void OnCollisionExit(Collision obj)
    {
        if(obj.gameObject.tag == "Block")
        {
            obj.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Anim.SetBool("Pullitem", false);
        }
    }
}
