using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadARModel : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("TurboJet");
    }
}