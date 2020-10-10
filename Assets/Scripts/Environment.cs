﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject rain;
    public GameObject[] cgs;

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
	#endregion

}
