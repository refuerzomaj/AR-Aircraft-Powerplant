using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class slidePanel : MonoBehaviour
{
    public GameObject newCanvas, prevCanvas;
    public void panelOn(){
        prevCanvas.gameObject.SetActive(false);
        newCanvas.gameObject.SetActive(true);
    }
    public void panelOff(){
        newCanvas.gameObject.SetActive(false);
        prevCanvas.gameObject.SetActive(true);
    }
    public void allPanelOff(){
        newCanvas.gameObject.SetActive(false);
        prevCanvas.gameObject.SetActive(false);
    }
}
