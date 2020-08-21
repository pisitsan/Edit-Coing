using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJECT_DOWN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            Invoke("Boxdown", 3);
        }
    }

    private void Boxdown()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
