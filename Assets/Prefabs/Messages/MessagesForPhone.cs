using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagesForPhone : MonoBehaviour
{
    public GameObject[] YourMessage;
    public GameObject[] TheirMessage;

    public int idx_YourMessage;

    public int idx_TheirMessage;

    public int idx_MessagePosition;

    public Dictionary<int,int> indexCorrelation = new Dictionary<int, int>();

    public List<GameObject> ListMessage;

    public GameObject[] PositionMessage = new GameObject[3];
    public GameObject PositionDiluar;

    public int[] Test_Position;

    public int test_Index;

    public bool Valid_Click;

    void Start()
    {
        idx_YourMessage = 0;
        idx_TheirMessage = 0;
        idx_MessagePosition = 0;
        test_Index = 0;
        Valid_Click = true;
        FillingDictionary();
    }

    public void StartTest()
    {
        if(Valid_Click)
        {
            Valid_Click = false;
            StartCoroutine(TestPhone());
        }
    }

    public IEnumerator TestPhone()
    {
        MessageChooser("Yours",Test_Position[test_Index]);
        yield return new WaitForSeconds(2);
        MessageChooser("Theirs",ProcessingReply(Test_Position[test_Index]));
        test_Index++;
        Valid_Click = true;
    }

    public void FillingDictionary()
    {
        indexCorrelation.Add(0,2);
        indexCorrelation.Add(1,4);
        indexCorrelation.Add(2,3);
        indexCorrelation.Add(3,5);
        indexCorrelation.Add(4,0);
        indexCorrelation.Add(5,1);
        indexCorrelation.Add(6,7);
        indexCorrelation.Add(7,6);
    }

    public void MessageChooser(string tipePesan, int index)
    {
        if(tipePesan.Equals("Yours"))
        {
            ListMessage.Add(YourMessage[index]);
        }

        if(tipePesan.Equals("Theirs"))
        {
            ListMessage.Add(TheirMessage[index]);
        }

        PesanController(ListMessage[ListMessage.Count-1]);
    }

    public void PesanController(GameObject PesanBaru)
    {
        int pesanIdx = ListMessage.IndexOf(PesanBaru);
        if(ListMessage.Count >3)
        {
            ListMessage[pesanIdx].transform.position = PositionMessage[0].transform.position;
            ListMessage[pesanIdx-1].transform.position = PositionMessage[1].transform.position;
            ListMessage[pesanIdx-2].transform.position = PositionMessage[2].transform.position;
            ListMessage[pesanIdx-3].transform.position = PositionDiluar.transform.position;
        }
        else
        { 
            switch(idx_MessagePosition)
            {
                case 0:
                UpdatePosisi_1(pesanIdx);
                break;
                case 1:
                UpdatePosisi_2(pesanIdx);
                break;
                case 2:
                UpdatePosisi_3(pesanIdx);
                break;
            }

        }
    }

    public void UpdatePosisi_1(int index)
    {
            ListMessage[index].transform.position = PositionMessage[0].transform.position;
            idx_MessagePosition++;
    }

    public void UpdatePosisi_2(int index)
    {
            ListMessage[index].transform.position = PositionMessage[0].transform.position;
            ListMessage[index-1].transform.position = PositionMessage[1].transform.position;
            idx_MessagePosition++;
    }

    public void UpdatePosisi_3(int index)
    {
            ListMessage[index].transform.position = PositionMessage[0].transform.position;
            ListMessage[index-1].transform.position = PositionMessage[1].transform.position;
            ListMessage[index-2].transform.position = PositionMessage[2].transform.position;
            idx_MessagePosition++;
    }

    public int ProcessingReply(int KeyMessage)
    {
        return indexCorrelation[KeyMessage];
    }

}
