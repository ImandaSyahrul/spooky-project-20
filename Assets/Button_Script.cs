using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Button_Script : MonoBehaviour
{
    public bool Panah_Valid;
    public Image Panah_1;
    public Image Panah_2;
    // Start is called before the first frame update
    void Start()
    {
        Panah_Mati();
    }

    public void Panah_Nyala()
    {
        Panah_Valid = true;
        Panah_1.GetComponent<Image>().color = new Color(255,255,255,255);
        Panah_2.GetComponent<Image>().color = new Color(255,255,255,255);
    }

    public void Panah_Mati()
    {
        Panah_Valid = false;
        Panah_1.GetComponent<Image>().color = new Color(255,255,255,0);
        Panah_2.GetComponent<Image>().color = new Color(255,255,255,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
