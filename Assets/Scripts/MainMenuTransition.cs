using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public enum MainMenu_Button
{
    Start,
    Continue,
    Setting,
    Quit
}
public class MainMenuTransition : MonoBehaviour
{
    public DOTweenAnimation SettingPanel;
    public DOTweenAnimation LoadPanel;
    public DOTweenAnimation StartPanel;

    public Button_Script Button_Start;
    public Button_Script Button_Continue;
    public Button_Script Button_Setting;
    public Button_Script Button_Quit;
    public GameObject Image_UI;
    public MainMenu_Button buttonMana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickButton_Start()
    {
        In_AnimationStart();
    }

    public void Hover_Button_Start()
    {
            Button_Start.Panah_Nyala();
            Button_Setting.Panah_Mati();
            Button_Continue.Panah_Mati();
            Button_Quit.Panah_Mati();
    }

    public void ClickButton_Setting()
    {
            In_AnimationSetting();
    }

    public void HoverButton_Setting()
    {
            Button_Start.Panah_Mati();
            Button_Continue.Panah_Mati();
            Button_Setting.Panah_Nyala();
            Button_Quit.Panah_Mati();
    }

    public void ClickButton_Continue()
    {
            In_AnimationLoad();
    }

    public void HoverButton_Continue()
    {
            Button_Start.Panah_Mati();
            Button_Continue.Panah_Nyala();
            Button_Setting.Panah_Mati();
            Button_Quit.Panah_Mati();
    }

    public void HoverButton_Quit()
    {
            Button_Start.Panah_Mati();
            Button_Continue.Panah_Mati();
            Button_Setting.Panah_Mati();
            Button_Quit.Panah_Nyala();
    }

    public void RestartStateHover()
    {
         Button_Start.Panah_Mati();
         Button_Continue.Panah_Mati();
         Button_Setting.Panah_Mati();
         Button_Quit.Panah_Mati();
    }

    public void In_AnimationSetting()
    {
        SettingPanel.gameObject.transform.DOLocalMoveX(0,1,true);
        SettingPanel.DOPlay();
    }

    public void Out_AnimationSetting()
    {
        SettingPanel.gameObject.transform.DOLocalMoveX(1215.156f,1,true);
        SettingPanel.DOPlay();
    }

    public void In_AnimationLoad()
    {
        LoadPanel.gameObject.transform.DOLocalMoveY(0,1,true);
        LoadPanel.DOPlay();
    }

    public void Out_AnimationLoad()
    {
        LoadPanel.gameObject.transform.DOLocalMoveY(867,1,true);
        LoadPanel.DOPlay();
    }

    public void In_AnimationStart()
    {
        StartPanel.gameObject.transform.DOLocalMoveX(0,1,true);
        StartPanel.DOPlay();
    }

    public void Out_AnimationStart()
    {
        StartPanel.gameObject.transform.DOLocalMoveX(-1325,1,true);
        StartPanel.DOPlay();
    }

    IEnumerator In_ConfirmedSettingAnimation()
    {
        Image_UI.transform.DOLocalMoveY(-287,0.3f,true);
        yield return new WaitForSeconds(1);
        Image_UI.transform.DOLocalMoveY(-633,0.3f,true);
    }

    public void ConfirmedSetting()
    {
        StartCoroutine(In_ConfirmedSettingAnimation());
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
