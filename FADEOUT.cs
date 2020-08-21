using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FADEOUT : MonoBehaviour
{
    public Image BlackFade;
    // Start is called before the first frame update
    void Start()
    {
        BlackFade.canvasRenderer.SetAlpha(1.5f);

        Fadeout();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fadeout()
    {
        BlackFade.CrossFadeAlpha(0, 5, false);
    }
}
