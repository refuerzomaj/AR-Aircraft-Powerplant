using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class showController : MonoBehaviour
{
    public Image img1,img2;
    void Start()
    {
        btnController();
    }

    void btnController()
    {
        if(GetComponent<Renderer>().isVisible)
        {
            spriteDeactivate();
        }
    }
    void spriteDeactivate()
    {
        img1.enabled = false;
        img2.enabled = false;
    }
}
