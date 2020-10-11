using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Fungus;
public class GameController : MonoBehaviour
{
    public GameObject buttonObject;
    public TextMeshProUGUI text;
    public GameObject jumpscarePanel;
    Vector3 idScale;
    int round = 10;
    void Start()
    {
        jumpscarePanel.SetActive(false);
        idScale = buttonObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ChangeText()
    {
        switch (round)
        {
            case 10:
                text.SetText("Click the Button for a prize!");
                break;
            case 9:
                text.SetText("Click it again!");
                break;
            case 8:
                text.SetText("Click it more!");
                break;
            case 7:
                text.SetText("Keep clicking it!");
                break;
            case 6:
                text.SetText("Again! Just keep clicking it!");
                break;
            case 5:
                text.SetText("You're almost there!");
                break;
            case 4:
                text.SetText("Click it some more!");
                break;
            case 3:
                text.SetText("The prize is waiting! Click it!");
                break;
            case 2:
                text.SetText("Almost there!");
                break;
            case 1:
                text.SetText("One more time!");
                break;
            default:
                text.SetText("Click the Button for a prize!");
                break;
        }
    }
    public void ButtonClicked()
    {
        round--;
        if (round > 0)
        {
            ChangeText();
            Vector3 newPos = new Vector3(Random.Range(-6f, 6f), Random.Range(-3.1f, 1.1f), 1f);
            Vector3 newScale = new Vector3(buttonObject.transform.localScale.x / 1.1f, buttonObject.transform.localScale.y / 1.1f, 0f);
            buttonObject.transform.position = newPos;
            buttonObject.transform.localScale = newScale;
        }
        else
        {
            StartCoroutine(Jumpscare());
        }
    }
    IEnumerator Jumpscare()
    {
        yield return null;
        jumpscarePanel.SetActive(true);
        float time = 5f;
        while (time > 0f)
        {
            yield return new WaitForSeconds(1f);
            time -= 1f;
        }
        yield return null;
        round = 10;
        ChangeText();
        buttonObject.transform.localScale = idScale;
        jumpscarePanel.SetActive(false);
        Flowchart.BroadcastFungusMessage("clear");
    }
}