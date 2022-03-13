using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentScript : MonoBehaviour
{
    public GameObject component;
    public GameObject onBtn;
    public GameObject offBtn;
    public GameObject text;

    public void hideComponents()
    {
        component.gameObject.SetActive(false);
        onBtn.gameObject.SetActive(true);
        offBtn.gameObject.SetActive(false);
        text.gameObject.SetActive(true);
    }
    public void showComponents()
    {
        component.gameObject.SetActive(true);
        onBtn.gameObject.SetActive(false);
        offBtn.gameObject.SetActive(true);
    }
    public void hideAll()
    {
        component.gameObject.SetActive(false);
        onBtn.gameObject.SetActive(false);
        offBtn.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
    }
}
