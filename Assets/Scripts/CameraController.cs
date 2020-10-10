using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraController : MonoBehaviour
{
    public Volume volume; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleBlur()
    {
        volume.weight = 1;
    }

    public void GoOutside()
    {
        transform.position = new Vector3(214.86f, 10.04f, -16.37f);
        transform.Rotate(new Vector3(-27.119f, -157.733f, -7.924f));
    }

    public void GoToWindow()
    {
        transform.position = new Vector3(218.668f, 7.584f, -36.413f);
        transform.rotation = new Quaternion(0f,10f,0f,270f);
    }

    public void GoToFront()
    {
        transform.position = new Vector3(220.966f, 7.348f, -35.874f);
        transform.rotation = new Quaternion(0f, 10f, 0f, 0f);
    }

    public void GoToFrontTV()
    {
        transform.position = new Vector3(220.966f, 7.348f, -38f);
        transform.Rotate( new Vector3(0f, 180f, 0f));
    }

    public void GoToComputer()
    {
        transform.position = new Vector3(217.775f, 7.269f, -38.161f);
        transform.Rotate( new Vector3(0f, -62.399f, 0f));
    }
}
