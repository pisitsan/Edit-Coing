using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESPAWN_5SEC : MonoBehaviour
{
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Invoke("Reposition", 15);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            CancelInvoke();
    }

    private void Reposition()
    {
        player.transform.position = respawnpoint.transform.position;
    }
}
