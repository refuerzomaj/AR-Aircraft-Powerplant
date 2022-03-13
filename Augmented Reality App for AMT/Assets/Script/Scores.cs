using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;
    public int playerScore;
    public string playerName;

    void Start()
    {
        scoreText.text = "Score:" + playerScore;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
    }

    void Update()
    {
        
    }
}
