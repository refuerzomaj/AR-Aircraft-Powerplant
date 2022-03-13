using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class imageController : MonoBehaviour
{
    public GameObject img1,img2,img3,img4,img5,img6;
    public void engineStartClick(){
        img1.gameObject.SetActive(false);
        img2.gameObject.SetActive(false);
        img3.gameObject.SetActive(true);
        img5.gameObject.SetActive(true);
    }
    public void disassembleClick(){
        img1.gameObject.SetActive(false);
        img2.gameObject.SetActive(false);
        img4.gameObject.SetActive(true);
    }
    public void engineStopClick(){
       img1.gameObject.SetActive(true);
       img2.gameObject.SetActive(true);
       img3.gameObject.SetActive(false);
       img5.gameObject.SetActive(false);
    }
    public void assembleClick(){
        img1.gameObject.SetActive(true);
        img2.gameObject.SetActive(true);
        img4.gameObject.SetActive(false);
    }
    public void showClick(){
        img6.gameObject.SetActive(true);
        img5.gameObject.SetActive(false);
        img3.gameObject.SetActive(false);

    }
    public void hideClick(){
        img6.gameObject.SetActive(false);
        img5.gameObject.SetActive(true);
        img3.gameObject.SetActive(true);
    }
}
