using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera[] arrayCamera;
    public int cameraIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        ResetCamera();
        UpdateCamera(0);
    }

    public void ResetCamera()
    {
        for(int i = 0; i < arrayCamera.Length; i++)
        {
            arrayCamera[i].gameObject.SetActive(false);
        }
    }

    public void NextCamera()
    {
        if(cameraIndex+1 < arrayCamera.Length)
        {
            cameraIndex++;
        }
        else
        {
            cameraIndex = 0;
        }

        UpdateCamera(cameraIndex);
        
    }

    public void PreviousCamera()
    {
        if(cameraIndex-1 < 0)
        {
            cameraIndex = arrayCamera.Length-1;
        }
        else
        {
            cameraIndex--;
        }
            UpdateCamera(cameraIndex);
    }

    public void TengahRotationCamera()
    {
        arrayCamera[cameraIndex].GetComponent<CameraRotationScript>().Tengah_Kamera();
    }
    public void KiriRotationCamera()
    {
        arrayCamera[cameraIndex].GetComponent<CameraRotationScript>().Kiri_Kamera();
    }

    public void KananRotationCamera()
    {
        arrayCamera[cameraIndex].GetComponent<CameraRotationScript>().Kanan_Kamera();
    }
    

    public void UpdateCamera(int indexCamera)
    {
        ResetCamera();
        arrayCamera[indexCamera].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
