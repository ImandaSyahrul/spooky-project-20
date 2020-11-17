using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class StoryManager : MonoBehaviour
{
    #region properties
    [SerializeField] private Flowchart _flowcharts;
    
	#endregion


	#region methods
	

    public void CallBlock(string name)
    {
        Flowchart.BroadcastFungusMessage(name);
    }

	#endregion


}
