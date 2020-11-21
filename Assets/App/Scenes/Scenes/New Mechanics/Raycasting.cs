using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EPOOutline;
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
             RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                 if(Physics.Raycast(ray,out hit, 100.0f))
                {
                    if(hit.transform != null)
                    {
                        if(Input.GetMouseButtonDown(0))
                        {
                            isclicked = true;
                            ClickItem(hit.transform.gameObject);
                        }
                        else
                        {
                            HoverEnterItem(hit.transform.gameObject);
                        }
                    }
                }
        }
        //TODO: Kayanya butuh bool isClicked biar cuma kepanggil sekali

    }

    public void HoverEnterItem(GameObject objclicked)
    {
        objclicked.GetComponent<EPOOutline.Outlinable>().enabled = true;
        //untuk activate layout.
    }

    public void HoverExitItem(GameObject objclicked)
    {
        objclicked.GetComponent<EPOOutline.Outlinable>().enabled = false;
        //untuk diactive layout.
    }
    public void ClickItem(GameObject objClicked)
    {
        
                        objClicked.GetComponent<EPOOutline.Outlinable>().enabled = true;
                        switch(objClicked.GetComponent<Item>().jenisItemnya)
                        {
                            case jenisItem.Interactable:
                            storyManager.CallBlock(objClicked.GetComponent<Item>().interactableMessage);
                            break;
                            case jenisItem.KeyItems:
                            managerQuest.QuestCheck(objClicked);
                            break;
                        }
                        StartCoroutine(clickedObject());
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
