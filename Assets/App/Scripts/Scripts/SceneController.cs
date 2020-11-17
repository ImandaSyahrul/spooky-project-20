using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToAdin()
    {
        SceneManager.LoadScene(2);
    }

    public void ToDina()
    {
        SceneManager.LoadScene(1);
    }
}
