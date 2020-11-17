using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public int indexQuest;
    public Quest[] questArray;

    public TextMeshProUGUI quest1;
    public TextMeshProUGUI quest2;

    public 
    // Start is called before the first frame update
    void Start()
    {
        indexQuest = 0;
        quest1.text = questArray[0].DescriptionObjective;
        quest2.text = questArray[1].DescriptionObjective;
    }
    
    public void QuestCheck(GameObject objectClicked)
    {
        if(objectClicked.name == questArray[indexQuest].keyItemName)
        {
            QuestCompleted(indexQuest);
        }
        else
        {
            Debug.Log("Not The Item Needed");
        }
    }

    public void NextQuestStart(int index)
    {
        //Being Called when the Next Quest Started
        if(indexQuest < questArray.Length)
        {
            if(questArray[index].isCompleted)
            {
                indexQuest++;
                if(indexQuest+1 < questArray.Length)
                {
                    quest2.text = questArray[indexQuest+1].DescriptionObjective;
                }
                
            }
        }
        else
        {
            Debug.Log("You have Completed Every Quest");
        }
    }

    public void QuestCompleted(int index)
    {
        //Being Called when the Quest Completed
        questArray[index].QuestInteract();
        Debug.Log("You have Completed Quest "+ index);
        StartCoroutine(UIQuestCompleted());
    }

    public IEnumerator UIQuestCompleted()
    {
        quest1.fontStyle = FontStyles.Strikethrough;
        yield return new WaitForSeconds(2);
        quest1.fontStyle = FontStyles.Normal;
        quest1.text = quest2.text;
        quest2.text = "";
        NextQuestStart(indexQuest);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
