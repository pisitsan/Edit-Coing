using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHANGSCENE : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            SceneManager.LoadScene("Scene1_2");
        //Anim.SetBool("Death", true);
    }
}