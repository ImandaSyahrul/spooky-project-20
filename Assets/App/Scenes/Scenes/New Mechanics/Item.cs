using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EPOOutline;
public enum jenisItem{
    nonInteractable,
    Interactable,
    KeyItems

}
public class Item : MonoBehaviour
{
    public Outlinable outline;
    public jenisItem jenisItemnya;
    public string interactableMessage;

    public void changeToKeyItems()
    {
        jenisItemnya = jenisItem.KeyItems;
    }

    public void changeToInteractable()
    {
        jenisItemnya = jenisItem.Interactable;
    }

    public void changeToNonInteractable()
    {
        jenisItemnya = jenisItem.nonInteractable;
    }

    void OnMouseOver()
    {
        outline.enabled = true;
    }
    void OnMouseExit()
    {
        outline.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        outline = this.GetComponent<EPOOutline.Outlinable>();
        outline.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
