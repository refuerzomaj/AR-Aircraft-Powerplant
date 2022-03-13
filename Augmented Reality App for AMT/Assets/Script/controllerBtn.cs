using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerBtn : MonoBehaviour
{
    public GameObject controllerPanel;
    int counter;
    public void controllerBtnClick(){
        counter++;
        if(counter%2 ==1)
        {
            controllerPanel.gameObject.SetActive(true);
        }
        else
        {
            controllerPanel.gameObject.SetActive(false);
        }
    }
}
