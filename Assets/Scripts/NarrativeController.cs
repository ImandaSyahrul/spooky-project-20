using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class NarrativeController : MonoBehaviour
{
    [Tooltip("Global Volume to blur environment")]
    public Volume globalVolume;
    [Tooltip("GameObject that contain cinematic panel")]
    public GameObject cinematicPanel;

    public void SetNarrativeVolume()
    {
        globalVolume.weight = 0.9f;
    }

    public void SetEnvironmentVolume()
    {
        globalVolume.weight = 0f;
    }

    public void TurnOnCinematic()
    {
        cinematicPanel.SetActive(true);
    }

    public void TurnOffCinematic()
    {
        cinematicPanel.SetActive(false);
    }

    public void FadeIn()
    {

    }
}
