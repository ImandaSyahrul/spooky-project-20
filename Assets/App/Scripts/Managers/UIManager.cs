using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Wiloka
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Managers" + nameof(UIManager))]
        public class UIManager : MonoBehaviour,IDisposable
        {
		#region fields
		private bool _isInited;
		private GameManager _gameManager;
		#endregion

		#region events
		
		#endregion

		#region properties
		public GameObject mainUI;
		public GameObject pauseUI;
		public GameObject dialogueUI;
		public GameObject settingsUI;
		#endregion

		#region methods
		void Init()
		{

		}
		#endregion

		#region IDisposable
		public void Dispose()
		{
			Destroy(gameObject);
		}
		#endregion
	}
}



