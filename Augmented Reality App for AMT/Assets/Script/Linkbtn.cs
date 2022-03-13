using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linkbtn : MonoBehaviour
{
    public GameObject Main_menuUI;
    [SerializeField]

    public GameObject ProfileUI;
    [SerializeField]
  public void OpenFacebook()
  {
      Application.OpenURL("https://www.facebook.com/PhilscaOfficial");
      Debug.Log("Working");
  }

  public void OpenWebiste()
  {
      Application.OpenURL("https://www.philsca.edu.ph/");
      Debug.Log("Working");
  }

}
