using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public bool isclicked;
    public StoryManager storyManager;

    public QuestManager managerQuest;
    // Start is called before the first frame update
    void Start()
    {
        storyManager = FindObjectOfType<StoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isclicked)
        {
            if(Input.GetMouseButtonDown(0))
            {
                ClickItem();
            }
        }
        //TODO: Kayanya butuh bool isClicked biar cuma kepanggil sekali

    }

    public void ClickItem()
    {
        RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if(Physics.Raycast(ray,out hit, 100.0f))
                {
                    if(hit.transform != null)
                    {
                        isclicked =true;
                        Debug.Log(hit.transform.gameObject.name);
                        //StartCoroutine(PrintName(hit.transform.gameObject));
                        //CheckItem(hit.transform.gameObject);
                        switch(hit.transform.gameObject.GetComponent<Item>().jenisItemnya)
                        {
                            case jenisItem.Interactable:
                            storyManager.CallBlock(hit.transform.gameObject.GetComponent<Item>().interactableMessage);
                            break;
                            case jenisItem.KeyItems:
                            managerQuest.QuestCheck(hit.transform.gameObject);
                            break;
                        }
                        StartCoroutine(clickedObject());
                    }
                }
    }

    public IEnumerator clickedObject()
    {
        yield return new WaitForSeconds(2);
        isclicked = false;
    }
    /*
    public void CheckItem(GameObject objectClicked)
    {
        string checkName = objectClicked.name;
        if(checkName == "Burger")
        {
            //TODO: IF FOUND ITEM
            Debug.Log("Berhasil Menemukan "+ checkName);
            isclicked = false;
        }
        else
        {
            //TODO: IF FOUND NOT ITEM
            Debug.Log("Itu Bukan Burger, tapi "+ checkName);
            isclicked = false;
        }
    }

    IEnumerator PrintName(GameObject go)
    {
        print(go.name);
        yield return new WaitForSeconds(1);
        isclicked = false;
    }
    */
}
