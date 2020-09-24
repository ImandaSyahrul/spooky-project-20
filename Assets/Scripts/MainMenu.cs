using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void StartGameAsDina()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGameAsAdin()
    {
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
