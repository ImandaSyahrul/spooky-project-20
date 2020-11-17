using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum jenisItem{
    nonInteractable,
    Interactable,
    KeyItems

}
public class Item : MonoBehaviour
{
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
