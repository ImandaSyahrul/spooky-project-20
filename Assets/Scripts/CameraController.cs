using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
