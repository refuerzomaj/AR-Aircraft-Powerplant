using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadSceneController : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }
}
