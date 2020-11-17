using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeline : MonoBehaviour
{
    public Text time;
    public Text date;

    public void SetFiveMins()
    {
        time.text = "00.05 AM";
    }

    public void SetFifteenMins()
    {
        time.text = "00.20 AM";
    }
}
