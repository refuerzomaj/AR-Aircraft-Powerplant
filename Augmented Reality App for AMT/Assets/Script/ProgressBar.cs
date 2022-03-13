using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    public Image LoadingBar;
    [SerializeField] private string sceneName;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
    void Update()
    {
        LoadingBar.fillAmount = currentAmount;
        if(currentAmount < 100){
            currentAmount += speed * Time.deltaTime;
        }else{
            SceneManager.LoadScene(sceneName);
        }
        LoadingBar.fillAmount = currentAmount / 100;
    }
}