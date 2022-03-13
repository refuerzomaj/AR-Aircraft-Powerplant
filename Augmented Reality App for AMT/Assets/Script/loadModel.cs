using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadModel : MonoBehaviour
{
    // Start is called before the first frame update
    string sceneName = "MainMenu";
    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }
}
