using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        showModel();
    }
    void showModel(){
        SceneManager.LoadScene("TurboJet");
    }
}
