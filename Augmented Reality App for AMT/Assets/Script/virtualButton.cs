using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour//, IVirtualButtonEventHandler
{
    private GameObject vButtonObject;

    void Start()
    {
        vButtonObject = GameObject.Find("actionButton");
       // vButtonObject.GetComponent<VirtualButtonBehavior>().RegisterEventHandler(this);
    }
    /*public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
        Debug.Log("Button Down");
    }
     public void OnButtonReleased (VirtualButtonAbstractBehaviour vb){
        Debug.Log("Button Up");
    }*/
}
