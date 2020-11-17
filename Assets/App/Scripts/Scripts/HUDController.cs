using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public GameObject phoneScreen;
    public GameObject settingsScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePhone()
    {
        if (phoneScreen.activeSelf) phoneScreen.SetActive(false);
        else phoneScreen.SetActive(true);
    }

    public void ToggleSettings()
    {
        if (settingsScreen.activeSelf) settingsScreen.SetActive(false);
        else settingsScreen.SetActive(true);
    }

}
