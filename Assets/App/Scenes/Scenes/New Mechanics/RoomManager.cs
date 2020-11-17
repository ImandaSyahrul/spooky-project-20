using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Rooms{
    MainRoom,
    BathRoom,
    Bedroom
}
public class RoomManager : MonoBehaviour
{
    public GameObject mainRoom;
    public GameObject bathRoom;
    public GameObject bedRoom;
    public CameraManager mainRoomManager;
    public CameraManager bathRoomManager;
    public CameraManager bedRoomManager;
    public Rooms RuanganSekarang;
    // Start is called before the first frame update
    void Start()
    {
        masukMainRoom();
    }

    public void ResetRoom()
    {
        mainRoom.SetActive(false);
        bathRoom.SetActive(false);
        bedRoom.SetActive(false);
    }

    public void masukMainRoom()
    {
        ResetRoom();
        mainRoom.SetActive(true);
        mainRoomManager.cameraIndex = 0;
        RuanganSekarang = Rooms.MainRoom;
    }

    public void masukbathRoom()
    {
        ResetRoom();
        bathRoom.SetActive(true);
        bathRoomManager.cameraIndex = 0;
        RuanganSekarang = Rooms.BathRoom;
    }

    public void masukbedRoom()
    {
        ResetRoom();
        bedRoom.SetActive(true);
        bedRoomManager.cameraIndex = 0;
        RuanganSekarang = Rooms.Bedroom;
    }

    public void nextCamera()
    {
        switch(RuanganSekarang)
        {
            case Rooms.MainRoom:
            mainRoomManager.NextCamera();
            break;
            case Rooms.BathRoom:
            bathRoomManager.NextCamera();
            break;
            case Rooms.Bedroom:
            bedRoomManager.NextCamera();
            break;
        }
    }

    public void previousCamera()
    {
        switch(RuanganSekarang)
        {
            case Rooms.MainRoom:
            mainRoomManager.PreviousCamera();
            break;
            case Rooms.BathRoom:
            bathRoomManager.PreviousCamera();
            break;
            case Rooms.Bedroom:
            bedRoomManager.PreviousCamera();
            break;
        }
    }

    public void KananRotationCamera()
    {

        switch(RuanganSekarang)
        {
            case Rooms.MainRoom:
            mainRoomManager.KananRotationCamera();
            break;
            case Rooms.BathRoom:
            bathRoomManager.KananRotationCamera();
            break;
            case Rooms.Bedroom:
            bedRoomManager.KananRotationCamera();
            break;
        }
    }

    public void KiriRotationCamera()
    {
        switch(RuanganSekarang)
        {
            case Rooms.MainRoom:
            mainRoomManager.KiriRotationCamera();
            break;
            case Rooms.BathRoom:
            bathRoomManager.KiriRotationCamera();
            break;
            case Rooms.Bedroom:
            bedRoomManager.KiriRotationCamera();
            break;
        }
    }

    public void TengahRotationCamera()
    {
        switch(RuanganSekarang)
        {
            case Rooms.MainRoom:
            mainRoomManager.TengahRotationCamera();
            break;
            case Rooms.BathRoom:
            bathRoomManager.TengahRotationCamera();
            break;
            case Rooms.Bedroom:
            bedRoomManager.TengahRotationCamera();
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
