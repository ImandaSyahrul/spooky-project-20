using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wiloka;

public class Quest : MonoBehaviour
{
    [SerializeField] private string interactableMessage;
    [SerializeField] private string questMessage;

    public StoryManager storyManager;

    public string keyItemName;
    public string DescriptionObjective;
    public bool isCompleted;

    //Mungkin ada Fungus Function yang bisa dipanggil (?)

    // Start is called before the first frame update
    void Start()
    {
        storyManager = FindObjectOfType<StoryManager>();
        isCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuestInteract()
    {
        storyManager.CallBlock(questMessage);
        isCompleted = true;
    }

    public void Interact()
    {
        storyManager.CallBlock(interactableMessage);
    }
}
