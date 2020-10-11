using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVMat_Controller : MonoBehaviour
{
    public Shader[] ChannelTV;

    public Shader TV_Korea;
    public Shader TV_Mati;

    public bool firstTimeTurnOn;

    public float TimerLength;

    public bool valid_Click;

    public bool isitDina;

    public Material TV_Material;
    // Start is called before the first frame update
    void Start()
    {
        TurnOff_TV();
    }

    public void TurnOff_TV()
    {
        TV_Material.shader = TV_Mati;
    }

    public void TurnOn_TV()
    {
        if(firstTimeTurnOn)
        {
            TV_Material.shader = TV_Korea;
            firstTimeTurnOn = false;
        }
        else
        {
            int index = Random.Range(0,ChannelTV.Length);
            if(index==ChannelTV.Length)index--;
            TV_Material.shader = ChannelTV[index];
        }
    }

    public IEnumerator ClickRemoteTV_On()
    {
        if(valid_Click)
        {
            valid_Click = false;
            TurnOn_TV();
            yield return new WaitForSeconds(TimerLength);
            TurnOff_TV();
            valid_Click = true;

        }
    }

    public IEnumerator ClickRemoteTV_Off()
    {
        valid_Click = false;
        TurnOff_TV();
        yield return new WaitForSeconds(TimerLength);
        TurnOn_TV();
        valid_Click = true;
    }
    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            StartCoroutine(ClickRemoteTV_On());
        }
    }

    public void Test()
    {
        Debug.Log("Test");
    }

    // Update is called once per frame
}
