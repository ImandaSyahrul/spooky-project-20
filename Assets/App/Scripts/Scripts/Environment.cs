using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject rain;
    public GameObject[] cgs;
    public GameObject qteHUD;
    public GameObject interactObjectUI;

    #region methods
    public void EnableRain()
    {
        rain.SetActive(true);
    }
    
    public void EnableFirstCG()
    {
        cgs[0].SetActive(true);
    }

    public void DisableFirstCG()
    {
        cgs[0].SetActive(false);
    }

    public void EnableSecondCG()
    {
        cgs[1].SetActive(true);
    }

    public void DisableSecondCG()
    {
        cgs[1].SetActive(false);
    }
    #endregion

    public void ActiveFirstQTE()
    {
        qteHUD.SetActive(true);
    }

    public void DeactiveFirstQTE()
    {
        qteHUD.SetActive(false);
    }

    public void EnableRemoteGUI()
    {
        interactObjectUI.SetActive(true);
    }

    public void DisableRemoteGUI()
    {
        interactObjectUI.SetActive(false);
    }
}
