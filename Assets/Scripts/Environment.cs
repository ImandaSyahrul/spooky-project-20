using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject rain;
    public GameObject[] cgs;
    public GameObject qteHUD;

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
}
