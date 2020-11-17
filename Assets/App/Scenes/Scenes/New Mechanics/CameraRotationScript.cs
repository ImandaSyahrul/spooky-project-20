using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraRotationScript : MonoBehaviour
{
    public Vector3 Rotation_Kiri;
    public Quaternion Rotation_Tengah;
    public Vector3 Rotation_Kanan;

    public Camera cameraNya;
    // Start is called before the first frame update
    void Start()
    {
        Rotation_Tengah =  cameraNya.GetComponent<Transform>().rotation;
    }

    public void Kanan_Kamera()
    {
        cameraNya.GetComponent<Transform>().DOLocalRotate(Rotation_Kanan,2);
    }

    public void Kiri_Kamera()
    {
        cameraNya.GetComponent<Transform>().DOLocalRotate(Rotation_Kiri,2);
    }

    public void Tengah_Kamera()
    {
        cameraNya.GetComponent<Transform>().DOLocalRotate(Rotation_Tengah.eulerAngles,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
