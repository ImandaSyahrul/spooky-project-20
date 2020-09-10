using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject loadPanel;
    public GameObject quitPanel;
    public GameObject settingsPanel;
    public GameObject[] buttons;

    public EventSystem eventSystem;

    private MenuNavigation nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = MenuNavigation.MAIN;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (nav == MenuNavigation.MAIN)
            {
                QuitGame();
            }
            else Back();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        nav = MenuNavigation.LOAD;
        loadPanel.SetActive(true);
    }

    public void Back()
    {
        switch (nav)
        {
            case MenuNavigation.LOAD:
                {
                    loadPanel.SetActive(false);
                    eventSystem.SetSelectedGameObject(buttons[1]);
                    break;
                }
            case MenuNavigation.SETTING:
                {
                    settingsPanel.SetActive(false);
                    eventSystem.SetSelectedGameObject(buttons[2]);
                    break;
                }
            case MenuNavigation.QUIT:
                {
                    quitPanel.SetActive(false);
                    eventSystem.SetSelectedGameObject(buttons[3]);
                    break;
                }
        }
        nav = MenuNavigation.MAIN;
    }

    public void OpenSettings()
    {
        nav = MenuNavigation.SETTING;
        settingsPanel.SetActive(true);
    }

    public void QuitGame()
    {
        nav = MenuNavigation.QUIT;
        quitPanel.SetActive(true);
    }
}
