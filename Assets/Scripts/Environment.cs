using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject rain;
    public GameObject[] cgs;
    
    public void EnableRain()
    {
        rain.SetActive(true);
    }
    
    public void EnableFirstCG()
    {
        cgs[0].SetActive(true);
    }

}
