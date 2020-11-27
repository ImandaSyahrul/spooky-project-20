using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public enum remoteSiapa{
    Adin,
    Dina
}
public class RemoteTV : MonoBehaviour
{
    public bool isTurnOn;
    public Material tvMaterial;
    public Shader[] channel_TV;

    public remoteSiapa QuestSiapa;

    public Shader tv_mati;
    public Shader channel_Utama;

    public Image Remote_Image;

    public bool validClick;

    public int index;
    // Start is called before the first frame update
    void Start()
    {
        validClick = false;
        isTurnOn = false;
        Matiin_TV();
        StartQuest();
    }

    public void StartQuest()
    {
        switch(QuestSiapa)
        {
            case remoteSiapa.Adin:
            StartQuestRemote_Adin();
            break;
            case remoteSiapa.Dina:
            StartQuestRemote_Dina();
            break;
        }
    }

    public void StartQuestRemote_Adin()
    {
        Nyala_TV();
        isTurnOn = true;
        Debug.Log("Start Quest Adin");
        StartCoroutine(remoteGoUp());
        /*
        Start Questnya Adin
        - Munculin Remote
        - Nyalain TVnya
        - Setiap Mati bakal nyala lagi TVnya.
        - harus ada index yang ngecek dia sampe 5 kali
        - Completed
        */
    }

    IEnumerator remoteGoUp()
    {
        Remote_Image.transform.DOLocalMove(new Vector3(-261,-44,0),1,true);
        yield return new WaitForSeconds(1);
    }

    IEnumerator remoteGoDown()
    {
        
        validClick = false;
        Remote_Image.transform.DOLocalMove(new Vector3(-261,-424,0),1,true);
        yield return new WaitForSeconds(1);
        validClick = false;
    }


    public void CheckQuestRemote_Adin()
    {
        index++;
        Debug.Log("Click Bertambah menjadi "+ index);
        //StartCoroutine(remoteGoUp());
        if(index==5)
        {
            Debug.Log("QuestCompleted");
            //
        }
        else
        {
            StartCoroutine(TVNyalaQuest());
        }
        //Check Questnya Adin
    }

    public void StartQuestRemote_Dina()
    {
        click_Channel();
        isTurnOn = true;
        Debug.Log("Start Quest Dina");
        StartCoroutine(remoteGoUp());
        /*
        Start Questnya Dina
        */
    }

    public void CheckQuestRemote_Dina()
    {
        index++;
        Debug.Log("Click Bertambah menjadi "+ index);
        if(index==5)
        {
            //diganti sama Fungus
            Debug.Log("QuestCompleted");
            Matiin_TV();
        }
        else
        {
            StartCoroutine(TVGantiQuest());
        }
        /*
        Check Questnya Dina.
        */
    }

    public void Matiin_TV()
    {
        isTurnOn = false;
        tvMaterial.shader = tv_mati;
    }

    public void Nyala_TV()
    {
        isTurnOn = true;
        tvMaterial.shader = channel_Utama;
    }

    IEnumerator TVNyalaQuest()
    {
        yield return new WaitForSeconds(1);
        Nyala_TV();
        yield return new WaitForSeconds(1);
        StartCoroutine(remoteGoUp());
        yield return new WaitForSeconds(1.5f);
        validClick = true;
    }

    IEnumerator TVGantiQuest()
    {
        yield return new WaitForSeconds(1);
        click_Channel();
        yield return new WaitForSeconds(1);
        StartCoroutine(remoteGoUp());
        yield return new WaitForSeconds(1.5f);
        validClick = true;

    }

    public void click_Power()
    {

        if(isTurnOn)
        {
            isTurnOn = false;
            Matiin_TV();
        }
        else
        {
            isTurnOn = true;
            tvMaterial.shader = channel_Utama;
        }
    }

    public void clickPowerButton()
    {
        
        StartCoroutine(remoteGoDown());
        validClick = false;
        switch(QuestSiapa)
        {
            case remoteSiapa.Adin:
            click_Power();
            CheckQuestRemote_Adin();
            break;
            case remoteSiapa.Dina:
            break;
        }
    }

    public void changeChannel()
    {
        int index = Random.Range(0,channel_TV.Length);
        if(index == channel_TV.Length) index --;
        tvMaterial.shader = channel_TV[index];
    }

    
    IEnumerator changeChannel_withTransition()
    {
        Matiin_TV();
        yield return new WaitForSeconds(0.5f);
        Nyala_TV();
        yield return new WaitForSeconds(0.5f);
        changeChannel();
    }

    public void click_Channel()
    {
        if(isTurnOn)StartCoroutine(changeChannel_withTransition());
    }

    public void clickChannelButton()
    {
        StartCoroutine(remoteGoDown());
        validClick = false;
        switch(QuestSiapa)
        {
            case remoteSiapa.Adin:
            break;
            case remoteSiapa.Dina:
            CheckQuestRemote_Dina();
            break;

        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
