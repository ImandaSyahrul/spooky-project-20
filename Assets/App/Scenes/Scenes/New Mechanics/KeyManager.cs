using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public RoomManager mRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            mRoom.KiriRotationCamera();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            mRoom.TengahRotationCamera();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            mRoom.KananRotationCamera();
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            mRoom.previousCamera();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            mRoom.nextCamera();
        }
    }
}
