using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    // Start is called before the first frame update

    /* Panel Settings */
    public GameObject settings_panel;
    public GameObject main_settings;
    public GameObject help_panel;
    public GameObject credits_panel;
    /* End */
    public void OpenSettingsPanel()
    {
        settings_panel.SetActive(true);
    }
    public void CloseSettingsPanel()
    {
        settings_panel.SetActive(false);
    }
    public void OpenHelp()
    {
        help_panel.SetActive(true);
        main_settings.SetActive(false);
    }

    public  void CloseHelp()
    {
        help_panel.SetActive(false);
        main_settings.SetActive(true);
    }
    public void OpenCredits()
    {
        credits_panel.SetActive(true);
        main_settings.SetActive(false);
    }

    public void CloseCredits()
    {
        credits_panel.SetActive(false);
        main_settings.SetActive(true);
    }
}
